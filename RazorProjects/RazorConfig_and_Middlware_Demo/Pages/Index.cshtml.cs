using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorConfig_and_Middlware_Demo.Pages
{
    public class IndexModel : PageModel
    {
    
        private readonly IConfiguration _config;
        public string Connection;
        public string Username { get; set; }
        public IndexModel(IConfiguration configuaration)
        {
          _config=configuaration;
        }

        public void OnGet()
        {
            Username = "Sarita";

          //  Connection = _config["ConnectionStrings:connect"];
        }
    }
}
