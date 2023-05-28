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

namespace ZeelandZoo.Pages.EventsCRUD
{

    public class IndexModel : PageModel
    {
        private readonly ZeelandZoo.Data.ApplicationDbContext _context;

        public IndexModel(ZeelandZoo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Events> Events { get; set; } = new List<Events>();

        public async Task OnGetAsync(string searchString)
        {
            IQueryable<Events> eventsQuery = _context.Events;

            if (!string.IsNullOrEmpty(searchString))
            {
                eventsQuery = eventsQuery.Where(e => e.Name.Contains(searchString));
            }

            Events = await eventsQuery.ToListAsync();
        }
    }
    
}
