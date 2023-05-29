using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZeelandZoo.Models;

namespace ZeelandZoo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ZeelandZoo.Data.ApplicationDbContext _context;

        public IndexModel(ZeelandZoo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<News> News { get; set; } = new List<News>();

        public async Task<IActionResult> OnGetAsync()
        {
            News = await _context.News.ToListAsync();
            return Page();
        }
    }
}