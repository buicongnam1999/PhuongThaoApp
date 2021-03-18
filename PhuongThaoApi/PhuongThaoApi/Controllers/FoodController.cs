using Microsoft.AspNetCore.Mvc;
using PhuongThao.Common.Class;
using PhuongThao.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhuongThaoApi.Controllers
{
    [Route("api/food")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        #region DECLARE
        FoodService _foodService;
        #endregion

        // GET: api/<FoodController>
        [HttpGet]
        public IEnumerable<object> Get()
        {
            this._foodService = new FoodService();
            return this._foodService.GetAllData();
        }

        // GET api/<FoodController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FoodController>
        [HttpPost]
        public ResultSet Post(Food nf)
        {
            _foodService = new FoodService();
            ResultSet rs = new ResultSet();
            if (this._foodService.CheckFoodCode(nf.food_code))
            {
                var res = this._foodService.InsertObject(nf);
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
            else
            {
                ErrMsg e = new ErrMsg();
                e.UserMessage = PhuongThaoApi.Properties.Resources.DuplicateUserEmail;
                rs.Sucess = false;
                rs.data = e;
                return rs;
            }
        }

        // PUT api/<FoodController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FoodController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
