using Microsoft.AspNetCore.Mvc;
using PhuongThao.Common.Class;
using PhuongThao.Service.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhuongThaoApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        UserService _userService = new UserService();
        [HttpGet]
        public IEnumerable Get()
        {
            return _userService.GetAllUser();
        }


        [HttpGet("customer")]
        public IEnumerable GetAllCustomer()
        {
            return _userService.getAllCustomer();
        }


        [HttpGet("employee")]
        public IEnumerable GetAllEmployee()
        {
            return _userService.getAllEmployee();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public ResultSet Post(User nuser)
        {
            ResultSet rs = new ResultSet();
            if (_userService.CheckUserName(nuser.u_name))
            {
                if (_userService.CheckUserEmail(nuser.user_email))
                {
                    var res = _userService.InsertUser(nuser);

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
            else
            {
                ErrMsg e = new ErrMsg();
                e.UserMessage = PhuongThaoApi.Properties.Resources.DuplicateUserName;
                rs.Sucess = false;
                rs.data = e;
                return rs;
            }
            
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public IActionResult Put(User u)
        {
            var res = _userService.UpdateUser(u);
            if (res > 0)
            {
                return StatusCode(200, "Thành công");
            }
            else
            {
                return StatusCode(400, "Thất bại");
            }
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var res = _userService.DeleteUser(id);
            if (res > 0)
            {
                return StatusCode(200, "Thành công");
            }
            else
            {
                return StatusCode(400, "Thất bại");
            }
        }


    }
}
