using PhuongThao.Common.Class;
using PhuongThao.DataLayer.DataLayer;
using PhuongThao.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongThao.Service.Service
{
    public class FoodService : IBaseService<Food>
    {
        #region DECLARE
        FoodConnect _foodConnect;
        #endregion

        #region Constructor
        public FoodService()
        {
            this._foodConnect = new FoodConnect();
        }
        #endregion

        #region Method


        #endregion

        public int DeleteObject(int id)
        {
            _foodConnect = new FoodConnect();
            return this._foodConnect.DeleteFood(id);
        }

        public IEnumerable<object> GetAllData()
        {
            _foodConnect = new FoodConnect();
            return this._foodConnect.GetAllProduct();
        }

        public int InsertObject(Food entity)
        {
            _foodConnect = new FoodConnect();
            return this._foodConnect.InsertFood(entity);
        }

        public int UpdateObject(Food entity)
        {
            _foodConnect = new FoodConnect();
            return this._foodConnect.UpdateFood(entity);
        }

        public Boolean CheckFoodCode(String code)
        {
            return this._foodConnect.CheckFoodCode(code);
        }
    }
}
