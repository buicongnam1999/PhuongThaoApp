using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using OfficeOpenXml;
using PhuongThao.Common.Class;
using PhuongThao.Service.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
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
        string fileName = @"Employees.xlsx";
        [HttpGet]
        public IEnumerable Get()
        {
            return _userService.GetAllUser();
        }

        /// <summary>
        /// Lấy toàn bộ thông tin khách hàng
        /// </summary>
        /// <returns>Danh sách khách hàng</returns>
        [HttpGet("customer")]
        public IEnumerable GetAllCustomer()
        {
            return _userService.getAllCustomer();
        }

        /// <summary>
        /// Lấy người dùng theo ID
        /// </summary>
        /// <param name="id">ID được truyền vào</param>
        /// <returns>Đối tượng người dùng</returns>
        [HttpGet("{id}")]
        public object GetUserById(int id)
        {
            return _userService.GetUserById(id).FirstOrDefault();
        }

        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns>Danh sách nhân viên</returns>
        [HttpGet("employee")]
        public IEnumerable GetAllEmployee()
        {
            return _userService.getAllEmployee();
        }

        /// <summary>
        /// Lấy thông tin khi đăng nhập
        /// </summary>
        /// <param name="name">Tài khoản người dùng</param>
        /// <param name="pass">Mật khẩu người dùng</param>
        /// <returns>Thông tin người đăng nhập</returns>
        [HttpGet("{name}&&{pass}")]
        public object CheckLoginUser(String name, String pass)
        {
            return _userService.CheckLoginUser(name, pass).FirstOrDefault();
        }


        // POST api/<UserController>

        /// <summary>
        /// Thêm mới người dùng
        /// </summary>
        /// <param name="nuser">Người dùng mới</param>
        /// <returns>Thông báo</returns>
        [HttpPost]
        public ResultSet Post(User nuser)
        {
            ResultSet rs = new ResultSet();

            // Kiểm tra tài khoản người dùng
            if (_userService.CheckUserName(nuser.u_name))
            {
                // Kiểm tra email người dùng
                if (_userService.CheckUserEmail(nuser.user_email))
                {
                    // Thêm mới người dùng
                    var res = _userService.InsertUser(nuser);

                    if (res > 0)
                    {   // Nếu đúng thì đưa ra thông báo 
                        ErrMsg e = new ErrMsg();
                        StatusCode(200);
                        rs.Sucess = true;
                        e.UserMessage = PhuongThaoApi.Properties.Resources.SucessTrue;
                        rs.data = e;
                    }
                    else
                    {
                        // Nếu sai đưa ra thông báo
                        ErrMsg e = new ErrMsg();
                        StatusCode(400);
                        e.UserMessage = PhuongThaoApi.Properties.Resources.SucessFail;
                        rs.data = e;
                    }
                    return rs;
                }
                else
                {
                    // Tồn tại email
                    ErrMsg e = new ErrMsg();
                    e.UserMessage = PhuongThaoApi.Properties.Resources.DuplicateUserEmail;
                    rs.Sucess = false;
                    rs.data = e;
                    return rs;
                }
            }
            else
            {
                // Tồn tại tài khoản
                ErrMsg e = new ErrMsg();
                e.UserMessage = PhuongThaoApi.Properties.Resources.DuplicateUserName;
                rs.Sucess = false;
                rs.data = e;
                return rs;
            }
            
        }

        // PUT api/<UserController>/5

        /// <summary>
        /// Cập nhập thông tin người dùng
        /// </summary>
        /// <param name="u">Người dùng cần cập nhật</param>
        /// <returns>Thông báo</returns>
        [HttpPut]
        public ResultSet Put(User u)
        {
            // Thực thi cập cập
            var res = _userService.UpdateUser(u);
            ErrMsg err = new ErrMsg();
            ResultSet rs = new ResultSet();
            // Nếu đùng
            if (res > 0)
            {

                rs.Sucess = true;
                err.UserMessage = PhuongThaoApi.Properties.Resources.SucessTrue;
                rs.data = err;
                return rs;
            }
            // Nếu sai
            else
            {
                rs.Sucess = false;
                err.UserMessage = PhuongThaoApi.Properties.Resources.SucessFail;
                rs.data = err;
                return rs;
            }
        }

        // DELETE api/<UserController>/5

        /// <summary>
        /// Xóa thông tin người dùng theo ID
        /// </summary>
        /// <param name="id">ID người dùng</param>
        /// <returns>Thông báo</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var res = _userService.DeleteUser(id);
            // Nếu đùng
            if (res > 0)
            {
                return StatusCode(200, PhuongThaoApi.Properties.Resources.SucessTrue);
            }
            // Nếu sai
            else
            {
                return StatusCode(400, PhuongThaoApi.Properties.Resources.UpdateFail);
            }
        }


        

        [HttpGet("excel/employee")]
        public void createFile()
        {
            string wwwrootPath = @"C:\Users\Bui Cong Nam\Desktop\PhuongThaoApp\PhuongThaoAPI\PhuongThaoAPI\wwwroot";
            
            FileInfo file = new FileInfo(Path.Combine(wwwrootPath, fileName));

            if (file.Exists)
            {
                file.Delete();
                file = new FileInfo(Path.Combine(wwwrootPath, fileName));
            }
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Nhân viên");
                DataTable employees = _userService.ExportExcelEmployees();
                int index = 2;
                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Tên nhân viên";
                worksheet.Cells[1, 3].Value = "Số điện thoại";
                worksheet.Cells[1, 4].Value = "Email";
                worksheet.Cells[1, 5].Value = "Địa chỉ";
                worksheet.Cells[1, 6].Value = "Lương";
                foreach (DataRow employee in employees.Rows)
                {
                    worksheet.Cells[String.Format("A{0}", index)].Value = employee[0].ToString();
                    worksheet.Cells[String.Format("B{0}", index)].Value = employee[1].ToString();
                    worksheet.Cells[String.Format("C{0}", index)].Value = employee[3].ToString();
                    worksheet.Cells[String.Format("D{0}", index)].Value = employee[4].ToString();
                    worksheet.Cells[String.Format("E{0}", index)].Value = employee[5].ToString();
                    worksheet.Cells[String.Format("F{0}", index)].Value = employee[11].ToString();
                    index++;
                }

                package.Save();
                IFileProvider provider = new PhysicalFileProvider(wwwrootPath);
                IFileInfo fileInfo = provider.GetFileInfo(fileName);
                var readStream = fileInfo.CreateReadStream();
                var mimeType = "application/vnd.ms-excel";
                File(readStream, mimeType, fileName);

            }

        }
        


    }
}
