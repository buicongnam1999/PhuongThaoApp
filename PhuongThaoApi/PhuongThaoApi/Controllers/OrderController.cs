using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using PhuongThao.Common.Class;
using PhuongThao.Service.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        [HttpGet]
        public IEnumerable<object> GetOrderByUser()
        {
            return _orderService.GetAllOder();
        }

        [HttpGet("{user_id}")]
        public IEnumerable<object> GetUserOrder(int user_id)
        {
            return _orderService.GetUserOrder(user_id);
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
            int order = this._orderService.InsertOrder(no);
            if (order == 0)
            {
                ErrMsg a = new ErrMsg();
                StatusCode(400);
                a.UserMessage = PhuongThaoApi.Properties.Resources.SucessFail;
                rs.data = a;
                return rs;
            }

            // Lấy mã thanh toán vừa thêm
            int orderID = this._orderService.GetUserOrderId(user_id);

            // Lấy danh sách trong giỏ hàng
            List<CartDetail> list = this._orderService.GetProductsCart(user_id);

            // Đếm số lượng sản phẩm
            int count = this._orderService.CountProductCart(user_id);

            // Thêm mới từng thành phần vào bảng thanh toán
            int res = this._orderService.InsertOrderDetail(list, orderID);

            // Kiểm tra đã đủ hàng hay chưa
            if (count != res)
            {
                ErrMsg c = new ErrMsg();
                StatusCode(400);
                c.UserMessage = PhuongThaoApi.Properties.Resources.InsertFail;
                rs.data = c;
                return rs;
            }
            // Cập nhật thông tin sản phẩm và xóa thông tin giỏ hàng
            foreach (var l in list)
            {
                int resUpdate = this._orderService.UpdateFood(l.food_id, l.quality);
                int resDelete = this._orderService.DeleteFoodCart(l.cart_id, l.food_id);
                if (resUpdate == 0)
                {
                    ErrMsg c = new ErrMsg();
                    StatusCode(400);
                    c.UserMessage = PhuongThaoApi.Properties.Resources.UpdateFail;
                    rs.data = c;
                    return rs;
                }
                if (resDelete == 0)
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
            if (resDeleteCart == 0)
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

        /// <summary>
        /// Gửi Email xác nhận mua hàng
        /// </summary>
        /// <param name="user_id">ID người dùng</param>
        /// <returns></returns>
        [HttpPost("email/{user_id}")]
        public ResultSet SendEmail(int user_id)
        {
            ResultSet rs = new ResultSet();
            try
            {
                var msg = new MimeMessage();
                String email = _orderService.GetEmailUser(user_id);
                msg.From.Add(new MailboxAddress("Cám ơn đã mua hàng từ Phương Thảo Shop", "chendanyul@gmail.com"));
                msg.To.Add(new MailboxAddress("Thank you", email));
                msg.Subject = "Cám ơn đã mua hàng từ Phương Thảo Shop";
                msg.Body = new TextPart("plain")
                {
                    Text = "Xin chào!\n Chúng tôi rất cám ơn bạn khi đã tin tưởng và mua sản phẩm từ Shop của chúng tôi",
                };
                using(var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com",587,false);
                    client.Authenticate("chendanyul@gmail.com", "123456789 0");
                    client.Send(msg);
                    client.Disconnect(true);
                }
                rs.Sucess = true;
                rs.data = PhuongThaoApi.Properties.Resources.SucessTrue;
               
            }
            catch (Exception ex)
            {
                rs.Sucess = false;
                rs.data = ex.ToString();
            }
            return rs;
        }


        [HttpPost("confirm/{user_id}")]
        public ResultSet UpdateOrder(int user_id)
        {
            ResultSet rs = new ResultSet();
            var res = _orderService.UpdateOrder(user_id);
            if (res > 0)
            {
                rs.Sucess = true;
                rs.data = PhuongThaoApi.Properties.Resources.SucessTrue;
                return rs;
            }
            else
            {
                rs.Sucess = false;
                rs.data = PhuongThaoApi.Properties.Resources.SucessFail;
            }
            return rs;
        }

        

    }
}