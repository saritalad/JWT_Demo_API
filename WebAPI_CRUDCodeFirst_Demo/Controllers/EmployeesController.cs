using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebAPI_CRUDCodeFirst_Demo.Models;

namespace WebAPI_CRUDCodeFirst_Demo.Controllers
{
    // [Route("api/[controller]")] 
     [ApiController]
    //base route
    [Route("Emp")]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDBContext _context;
        
        public EmployeesController(AppDBContext context)
        {
            _context = context;
        }



        [HttpGet]
        [Route("GetAllEmployees")]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return _context.Employees.ToList();

        }

        [HttpPost]
      //  [Route("/AddnewEmp")]
        public ActionResult Post([FromBody]Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
          //  return Ok();
            return CreatedAtAction("get",new { id = emp.Id },emp);  

        }

        [HttpGet("{id}")]
       // [Route("/GetEmployeeById/{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var emp = _context.Employees.First(x => x.Id == id);

            return emp;

        }
        [HttpPut("{id}")]
       // [Route("/UpdateEmp/{id}")]
        public ActionResult Put(int id, [FromBody]Employee emp)
        {
            if (id != emp.Id)
            {
                return BadRequest();
            }
            else
            {
                var data = _context.Employees.FirstOrDefault(x => x.Id == id);
                

                    data.Name = emp.Name;
                    data.Contact = emp.Contact;
                    _context.SaveChanges();
                    return NoContent();
               
            }
                    }
        [HttpDelete("{id}")]
      //  [Route("/DeleteEmp/{id}")]
        public ActionResult Delete(int id)
        {
            var data = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                _context.Employees.Remove(data);
                _context.SaveChanges();
                return NoContent();
            }
            else { return NotFound(); }

        }





    }
}