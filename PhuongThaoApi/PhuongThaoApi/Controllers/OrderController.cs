using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhuongThao.Common.Class;
using PhuongThao.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhuongThaoApi.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderService _orderService = new OrderService();
        CartService _cartService = new CartService();

        /// <summary>
        /// Hiển thị danh sách thanh toán theo người dùng
        /// </summary>
        /// <param name="id">ID người dùng</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IEnumerable<object> GetOrderByUser(int id)
        {
            return _orderService.GetOrderByUser(id);
        }

        /// <summary>
        /// Thanh toán theo người dùng
        /// </summary>
        /// <param name="user_id">ID người dùng</param>
        /// <returns></returns>
        [HttpPost("{user_id}")]
        public ResultSet InsertOrder(int user_id)
        {
            ResultSet rs = new ResultSet();

            // Lấy toàn bộ thông tin giỏ hàng hiện tại
            // Lấy số hàng có trong giỏ
            int sumProduct = this._orderService.CountProductCart(user_id);

            // Thêm mới giỏ hàng
            // Khai báo thông tin thêm
            Order no = new Order();
            no.order_note = "OK";
            no.order_status = 0;
            no.u_id = user_id;
            no.order_date = DateTime.Now;
            int order =this._orderService.InsertOrder(no);
            if(order == 0)
            {
                ErrMsg a = new ErrMsg();
                StatusCode(400);
                a.UserMessage = PhuongThaoApi.Properties.Resources.SucessFail;
                rs.data = a;
                return rs;
            }

            // Lấy mã thanh toán vừa thêm
            int orderID = this._orderService.GetUserOrder(user_id);

            // Lấy danh sách trong giỏ hàng
            List<CartDetail> list = this._orderService.GetProductsCart(user_id);

            // Đếm số lượng sản phẩm
            int count = this._orderService.CountProductCart(user_id);

            // Thêm mới từng thành phần vào bảng thanh toán
            int res = this._orderService.InsertOrderDetail(list, orderID);
            
            // Kiểm tra đã đủ hàng hay chưa
            if(count != res)
            {
                ErrMsg c = new ErrMsg();
                StatusCode(400);
                c.UserMessage = PhuongThaoApi.Properties.Resources.InsertFail;
                rs.data = c;
                return rs;
            }
            // Cập nhật thông tin sản phẩm và xóa thông tin giỏ hàng
            foreach(var l in list)
            {
                int resUpdate = this._orderService.UpdateFood(l.food_id, l.quality);
                int resDelete = this._orderService.DeleteFoodCart(l.cart_id, l.food_id);
                if(resUpdate  == 0)
                {
                    ErrMsg c = new ErrMsg();
                    StatusCode(400);
                    c.UserMessage = PhuongThaoApi.Properties.Resources.UpdateFail;
                    rs.data = c;
                    return rs;
                }
                if(resDelete == 0)
                {
                    ErrMsg d = new ErrMsg();
                    StatusCode(400);
                    d.UserMessage = PhuongThaoApi.Properties.Resources.DeleteFail;
                    rs.data = d;
                    return rs;
                }
            }

            // Xóa thông tin giỏ hàng
            int resDeleteCart = this._orderService.DeleteCart(this._orderService.GetCartByUserId(user_id));
            if(resDeleteCart == 0)
            {
                ErrMsg d = new ErrMsg();
                StatusCode(400);
                d.UserMessage = PhuongThaoApi.Properties.Resources.DeleteFail;
                rs.data = d;
                return rs;
            }

            ErrMsg e = new ErrMsg();
            StatusCode(200);
            rs.Sucess = true;
            e.UserMessage = PhuongThaoApi.Properties.Resources.SucessTrue;
            rs.data = e;

            return rs;
        }

    }
}
