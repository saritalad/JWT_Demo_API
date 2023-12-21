using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iDENTITY_DemoWebAppRazorPages.Pages
{
    [Authorize]
    public class ProductModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
