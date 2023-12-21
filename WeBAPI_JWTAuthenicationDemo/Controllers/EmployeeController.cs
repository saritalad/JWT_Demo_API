using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeBAPI_JWTAuthenicationDemo.Models;

namespace WeBAPI_JWTAuthenicationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        [Route("Getdata")]
        public string Getdata()
        {
            return "Authorized with JWT";
        }
        [HttpGet]
      
        [Route("Getdetails")]
        public string Details()
        {
            return "Authorized with JWT";
        }
        [HttpPost]
        [Authorize]
      
        public string AddUser(Users user)
        {
            return "user added with Username "+user.UserName;
        }
    }
}
