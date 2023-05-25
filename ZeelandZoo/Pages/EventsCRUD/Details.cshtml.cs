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
    public class DetailsModel : PageModel
    {
        private readonly ZeelandZoo.Data.ApplicationDbContext _context;

        public DetailsModel(ZeelandZoo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
