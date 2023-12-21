using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages.Employees
{
    public class IndexModel : PageModel
    {
        public List<string> employeelist = new List<string>() { "Abdul", "Viramallu", "Tanuja", "Rajendra" };
        public void OnGet()
        {
        }
    }
}
