using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_CrossSiteScriptingDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [Route("PostContactMessage")]
        [HttpPost]
        public async Task<IActionResult> PostContactMessage(ContactFormModel model)
        {
            if (model != null)
            {
                return Ok("Success");
            }

            else { return BadRequest(); }
        }



    }


    public class ContactFormModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string message { get; set; }
    }



}
