using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using ZeelandZoo.Models;

namespace ZeelandZoo.Pages.Calendar
{
    public class IndexModel : PageModel
    {
        public IndexModel(ZeelandZoo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly ZeelandZoo.Data.ApplicationDbContext _context;

        public IList<Events> Events { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Events != null)
            {
                Events = await _context.Events.ToListAsync();
            }
        }

    }
}


