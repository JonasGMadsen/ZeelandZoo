using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZeelandZoo.Data;
using ZeelandZoo.Models;

namespace ZeelandZoo.Pages.NewsCRUD
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly ZeelandZoo.Data.ApplicationDbContext _context;

        public IndexModel(ZeelandZoo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<News> News { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.News != null)
            {
                News = await _context.News.ToListAsync();
            }
        }
    }
}
