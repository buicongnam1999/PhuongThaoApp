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
    [Route("api/cart")]
    [ApiController]
    public class CartController : ControllerBase
    {

        CartService _cartService = new CartService();
        CartDetailService _cartDetailService = new CartDetailService();

        /// <summary>
        /// Lấy danh giỏ hàng theo người dùng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IEnumerable<object> GetCartByUser(int id)
        {
            return this._cartService.GetCartByUser(id);
        }

        /// <summary>
        /// Đếm số lượng sản phẩm trong giỏ hàng theo người dùng
        /// </summary>
        /// <param name="user_id">ID người dùng</param>
        /// <returns>Số lượng sản phẩm</returns>
        [HttpGet("count/{user_id}")]
        public int CountProduct(int user_id)
        {
            return _cartService.CountProduct(user_id);
        }

        /// <summary>
        /// Thêm vào giỏ hàng theo người dùng
        /// </summary>
        /// <param name="user_id">ID người dùng</param>
        /// <param name="product_id">ID của sản phẩm</param>
        /// <returns>Thông báo thực thi</returns>
        [HttpPost("{user_id}&&{product_id}")]
        public ResultSet InsertCart(int user_id, int product_id)
        {
            ResultSet rs = new ResultSet();
            // Kiểm tra đã tồn tại giỏ hàng chưa
            if (_cartService.GetCartByUserId(user_id) > 0)
            {
                // Kiểm tra xem sản phẩm tồn tại chưa
                if (_cartDetailService.CheckProduct(product_id, user_id))
                {
                    // Tăng thêm số lượng
                    int res = _cartDetailService.UpdateProductDetail(1, _cartService.GetCartByUserId(user_id), product_id);
                    // Kiểm tra xem đã thực thi chưa
                    if (res > 0)
                    {
                        ErrMsg e = new ErrMsg();
                        StatusCode(200);
                        rs.Sucess = true;
                        e.UserMessage = PhuongThaoApi.Properties.Resources.SucessTrue;
                        rs.data = e;
                    }
                    else
                    {
                        ErrMsg e = new ErrMsg();
                        StatusCode(400);
                        e.UserMessage = PhuongThaoApi.Properties.Resources.SucessFail;
                        rs.data = e;
                    }
                }
                else
                {
                    // Chưa tồn tại sản phẩm thì thêm
                    int res = _cartDetailService.InsertCart(_cartService.GetCartByUserId(user_id), product_id);
                    if (res > 0)
                    {
                        ErrMsg e = new ErrMsg();
                        StatusCode(200);
                        rs.Sucess = true;
                        e.UserMessage = PhuongThaoApi.Properties.Resources.SucessTrue;
                        rs.data = e;
                    }
                    else
                    {
                        ErrMsg e = new ErrMsg();
                        StatusCode(400);
                        e.UserMessage = PhuongThaoApi.Properties.Resources.SucessFail;
                        rs.data = e;
                    }
                }

            }
            else
            {
                // Chưa tồn tại giỏ hàng thì thêm giỏ hàng
                Cart c = new Cart();
                c.u_id = user_id;
                c.cart_note = "";
                // Thêm mới giỏ hàng
                _cartService.InsertCart(c);
                // Thêm mới sản phẩm
                int res = _cartDetailService.InsertCart(_cartService.GetCartByUserId(user_id), product_id);
                if(res > 0)
                {
                    ErrMsg e = new ErrMsg();
                    StatusCode(200);
                    rs.Sucess = true;
                    e.UserMessage = PhuongThaoApi.Properties.Resources.SucessTrue;
                    rs.data = e;
                }
                else
                {
                    ErrMsg e = new ErrMsg();
                    StatusCode(400);
                    e.UserMessage = PhuongThaoApi.Properties.Resources.SucessFail;
                    rs.data = e;
                }
            }
            return rs;
        }


        /// <summary>
        /// Cập nhật giỏ hàng khi giảm
        /// </summary>
        /// <param name="user_id">ID người dùng</param>
        /// <param name="product_id">ID sản phẩm</param>
        /// <returns></returns>
        [HttpDelete("reduction/{user_id}&&{product_id}")]
        public ResultSet UpdateProductReduction(int user_id, int product_id)
        {
            ResultSet rs = new ResultSet();
            // Kiểm tra xem có tồn tài giỏ hàng người dùng không
            if(_cartService.GetCartByUserId(user_id) > 0)
            {
                // Nếu tồn tại thì lấy ID giỏ hàng
                int res = _cartDetailService.UpdateProductReduction(1, _cartService.GetCartByUserId(user_id), product_id);
                // Kiểm tra đã thực thi chưa
                if (res > 0)
                {
                    ErrMsg e = new ErrMsg();
                    StatusCode(200);
                    rs.Sucess = true;
                    e.UserMessage = PhuongThaoApi.Properties.Resources.SucessTrue;
                    rs.data = e;
                }
                else
                {
                    ErrMsg e = new ErrMsg();
                    StatusCode(400);
                    e.UserMessage = PhuongThaoApi.Properties.Resources.SucessFail;
                    rs.data = e;
                }
            }
            else
            {
                // Nếu chưa đưa ra thông báo cho người dùng
                ErrMsg e = new ErrMsg();
                StatusCode(400);
                e.UserMessage = PhuongThaoApi.Properties.Resources.DuplicateNull;
                rs.data = e;
            }


            return rs;
        }

        /// <summary>
        /// Thêm mới giỏ hàng
        /// </summary>
        /// <param name="ncart">Giỏ hàng mới</param>
        /// <returns>Thông báo thực thi</returns>
        [HttpPost]
        public ResultSet InsertCart(Cart ncart)
        {
            ResultSet rs = new ResultSet();

            // Thêm mới giỏ hàng
            if(this._cartService.InsertCart(ncart) > 0)
            {
                // Thực thi đúng đưa ra thông báo
                ErrMsg e = new ErrMsg();
                StatusCode(200);
                rs.Sucess = true;
                e.UserMessage = PhuongThaoApi.Properties.Resources.SucessTrue;
                rs.data = e;
            }
            else
            {
                // Thực thi sai đưa ra thông báo
                ErrMsg e = new ErrMsg();
                StatusCode(400);
                e.UserMessage = PhuongThaoApi.Properties.Resources.SucessFail;
                rs.data = e;
            }
            return rs;
        }

        /// <summary>
        /// Xóa sản phẩm theo người dùng
        /// </summary>
        /// <param name="user_id">ID của người dùng</param>
        /// <param name="product_id">ID sản phẩm xóa</param>
        /// <returns>Thông báo thực thi</returns>
        [HttpDelete("{user_id}&&{product_id}")]
        public ResultSet DeleteProductCart(int user_id , int product_id)
        {
            ResultSet rs = new ResultSet();
            // Lấy giỏ hàng của khách hàng
            int id = _cartService.GetCartByUserId(user_id);

            // Thực thi xóa
            var res = _cartDetailService.DeleteProduct(id, product_id);
            if(res > 0)
            {
                ErrMsg e = new ErrMsg();
                StatusCode(200);
                rs.Sucess = true;
                e.UserMessage = PhuongThaoApi.Properties.Resources.SucessTrue;
                rs.data = e;
            }
            else
            {
                ErrMsg e = new ErrMsg();
                StatusCode(400);
                e.UserMessage = PhuongThaoApi.Properties.Resources.SucessFail;
                rs.data = e;
            }

            return rs;
        }



    }
}
