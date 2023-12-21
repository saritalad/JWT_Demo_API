using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XSS_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class demoController : ControllerBase
    {
        [Route("PostComtactMessage")]
        [HttpPost]
        public async Task <IActionResult> PostComtactMessage(ContactForModel model)
        {
            if (model!=null) {
                return Ok("Success");

                 }
            else
                return BadRequest();

        }
    }

    public class ContactForModel
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
