using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_953503_Alshanikov.Data;
using Web_953503_Alshanikov.Entities;

namespace Web_953503_Alshanikov.Areas.Admin.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Web_953503_Alshanikov.Data.ApplicationDbContext _context;

        public IndexModel(Web_953503_Alshanikov.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; }

        public async Task OnGetAsync()
        {
            Dish = await _context.Dishes
                .Include(d => d.Group).ToListAsync();
        }
    }
}
