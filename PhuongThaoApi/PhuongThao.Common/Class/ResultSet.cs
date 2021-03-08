using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class ResultSet
    {
        /// <summary>
        /// Trả về thực thi
        /// </summary>
        public Boolean Success { get; set; }

        /// <summary>
        /// Dữ liệu trả về
        /// </summary>
        public object data { set; get; }
    }
}
