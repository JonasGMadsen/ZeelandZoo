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
    public class DeleteModel : PageModel
    {
        private readonly ZeelandZoo.Data.ApplicationDbContext _context;

        public DeleteModel(ZeelandZoo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Events Events { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Events == null)
            {
                return NotFound();
            }

            var events = await _context.Events.FirstOrDefaultAsync(m => m.Id == id);

            if (events == null)
            {
                return NotFound();
            }
            else 
            {
                Events = events;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Events == null)
            {
                return NotFound();
            }
            var events = await _context.Events.FindAsync(id);

            if (events != null)
            {
                Events = events;
                _context.Events.Remove(Events);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
