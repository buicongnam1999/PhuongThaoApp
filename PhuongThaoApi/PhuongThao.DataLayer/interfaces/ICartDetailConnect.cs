using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.DataLayer.interfaces
{
    public interface ICartDetailConnect<T>
    {
        public IEnumerable<object> GetAllProduct(int id);

        public int InsertCart(int cart_id, int product_id);

        public int UpdateProduct(int amount, int cart_id, int product_id);

        public int DeleteProduct(int cart_id, int product_id);
    }
}
