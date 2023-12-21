using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazoEFrCodeFirstDemo.Models;

namespace RazoEFrCodeFirstDemo.Pages
{
    public class CreateModel : PageModel
    {
        public AppDBContext? _context { get; set; }
        [BindProperty]
        public Department department { get; set; }

        public CreateModel(AppDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid )
            {
                return Page();

            }
            _context.Departments.Add(department);
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }

    }
}
