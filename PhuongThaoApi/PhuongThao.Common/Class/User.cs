using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class User
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int u_id { get; set; }

        /// <summary>
        /// Tên người dùng
        /// </summary>
        public String user_fullname { get; set; }

        /// <summary>
        /// Giới tính
        /// </summary>
        public byte user_gender { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public String user_phone { get; set; }

        /// <summary>
        /// Địa chỉ email
        /// </summary>
        public String user_email { get; set; }

        /// <summary>
        /// Địa chỉ 
        /// </summary>
        public String user_address { get; set; }

        /// <summary>
        /// Tài khoản
        /// </summary>
        public String? u_name { get; set; }

        /// <summary>
        /// Mật khẩu
        /// </summary>
        public String user_pass { get; set; }

        /// <summary>
        /// Kiểu loại người dùng
        /// </summary>
        public int user_type { get; set; }

        /// <summary>
        /// Hình ảnh người dùng
        /// </summary>
        public String user_img { get; set; }

        /// <summary>
        /// Trạng thái người dùng
        /// </summary>
        public int user_status { get; set; }

        /// <summary>
        /// Lương người dùng
        /// </summary>
        public int salary { get; set; }
    }
}
