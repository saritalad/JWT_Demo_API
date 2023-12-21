using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazoEFrCodeFirstDemo.Models;

namespace RazoEFrCodeFirstDemo.Pages
{
    public class IndexModel : PageModel
    {
        public AppDBContext? _context { get; set; }
        public List<Department>?departmentlist { get; set; }

        public IndexModel(AppDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            departmentlist=_context.Departments.ToList();

        }
    }
}