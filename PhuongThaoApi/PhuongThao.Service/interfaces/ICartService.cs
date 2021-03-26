using PhuongThao.Common.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Service.interfaces
{
    public interface ICartService<T>
    {
        public int InsertCart(T ncart);

        public int UpdateCart(T c);

        public int DeleteCart(int id);
        
    }
}
