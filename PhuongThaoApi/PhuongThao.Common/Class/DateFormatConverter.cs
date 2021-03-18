using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Common.Class
{
    public class DateFormatConverter : IsoDateTimeConverter
    {
        #region Contructor
        public DateFormatConverter()
        {
            base.DateTimeFormat = "dd-MM-yyyy";
        }
        #endregion

    }
}
