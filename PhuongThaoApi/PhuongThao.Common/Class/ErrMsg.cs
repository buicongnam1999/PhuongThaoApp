using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class ErrMsg
    {
        /// <summary>
        /// Thông báo cho Dev
        /// </summary>
        public String devMessage;

        /// <summary>
        /// Thông báo cho Usẻ
        /// </summary>
        public String userMessage;

        public String DevMessage { set => devMessage = value; get => devMessage; }
        public String UserMessage { set => userMessage = value; get => userMessage; }
    }
}
