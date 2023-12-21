using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebApIDemo.Controllers.Models;

namespace WebApIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private IMembers members=new MembersRepository();
        [HttpGet]
        public ActionResult <IEnumerable<Member>>Get()
        {
            return members.GetMembers();
        }

        [HttpGet("{id}")]
        public ActionResult <Member> Get(int id)
        {
            return members.GetMember(id);
        }
        
    }
}
