using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Routing_Demo.Controllers
{
  //  [Route("api/[controller]")]
    [ApiController]
    [Route("Emp")]
    public class EmployeesController : ControllerBase
    {// Routing Parameter example
        [Route("Emp/Department/{Department}/Gender/{Gender}/City/{City}")]
        public string SearchMembers(string Department, string Gender, string City)
        {
            return $"Return Employees with Department : {Department}, Gender : {Gender}, City : {City}";
        }
        // Query String Example

        [Route("Employee/Search")]
        public string SearchEmployees(string Department, string Gender, string City)
        {
            return $"Return Employees with Department : {Department}, Gender : {Gender}, City : {City}";
        }

        [Route("Emp/All")]
        public string GetAllEmployees()
        {
            return "Response from GetAllEmployees Method";
        }
        [Route("Emp/ById")]
        public string GetEmployeeById()
        {
            return "Response from GetEmployeeById Method";
        }
        [Route("Employee/{Id}")]
        public string GetEmployeeById(int Id)
        {
            return $" Employee Details : {Id}";
        }

        // Base Route overriding 
        [Route("~/department/{department}")]
        public string GetDepartmentEmployees(string Department)
        {
            return $"Response from GetDepartmentEmployees Method, Department : {Department}";
        }




    }
}
