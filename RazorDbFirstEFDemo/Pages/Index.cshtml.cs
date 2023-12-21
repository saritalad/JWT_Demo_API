using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorDbFirstEFDemo.Models;

namespace RazorDbFirstEFDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _context;
       // _context=new AppDBContext(); automatically becoz of DI
        public IList<Product> Productlist { get; set; } = default!;
        public IndexModel(AppDBContext context)// injecting ref of AppDbContext in Constructor
        {
            _context = context;
        }

        

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            { // select * from Products   query is fired by AppDBcontext obj _context
                Productlist = await _context.Products.ToListAsync();
            }
        }
    }
}
