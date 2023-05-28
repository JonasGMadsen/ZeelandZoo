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

namespace ZeelandZoo.Pages.NewsCRUD
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
        public News News { get; set; } = default!;
        


        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.News == null || News == null)
            {
                return Page();
            }

            _context.News.Add(News);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
