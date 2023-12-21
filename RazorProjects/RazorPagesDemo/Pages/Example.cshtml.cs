using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class ExampleModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        public List<string> Fruits = new List<string>() { "Apple", "Banana", "Mango", "Orange", "Grapes" };



    }
}
