using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class PageRequest
    {
        /// <summary>
        /// Trang thứ
        /// </summary>
        public int PageIndex { set; get; }

        /// <summary>
        /// Kích thước trang
        /// </summary>
        public int PageSize { set; get; }

        public PageRequest(int pageIndex = 1, int pageSize = 10)
        {
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
        }
    }
}
