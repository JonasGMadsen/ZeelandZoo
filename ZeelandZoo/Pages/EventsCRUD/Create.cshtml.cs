using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZeelandZoo.Data;
using ZeelandZoo.Models;

namespace ZeelandZoo.Pages.EventsCRUD
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly ZeelandZoo.Data.ApplicationDbContext _context;

        public CreateModel(ZeelandZoo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Events Events { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Events == null || Events == null)
            {
                return Page();
            }

            _context.Events.Add(Events);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
