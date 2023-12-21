using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazoEFrCodeFirstDemo.Models;

namespace RazoEFrCodeFirstDemo.Pages
{
    public class EditModel : PageModel
    {
        public AppDBContext? _context { get; set; }
        [BindProperty]
        public Department department { get; set; }

        public EditModel(AppDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            department = _context.Departments.FirstOrDefault(d => d.Id == id);

            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _context.Attach(department).State = EntityState.Modified;

                _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
