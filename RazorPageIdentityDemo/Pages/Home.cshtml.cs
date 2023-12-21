using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageIdentityDemo.Pages
{
    [Authorize]
    public class HomeModel : PageModel
    {
        
        public void OnGet()
        {
        }
    }
}
