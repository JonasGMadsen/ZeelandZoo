using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZeelandZoo.Data;
using ZeelandZoo.Models;

namespace ZeelandZoo.Pages.EventsCRUD
{
    public class IndexModel : PageModel
    {
        private readonly ZeelandZoo.Data.ApplicationDbContext _context;

        public IndexModel(ZeelandZoo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Events> Events { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Events != null)
            {
                Events = await _context.Events.ToListAsync();
            }
        }
    }
}
