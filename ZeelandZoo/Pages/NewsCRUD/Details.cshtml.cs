﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZeelandZoo.Data;
using ZeelandZoo.Models;

namespace ZeelandZoo.Pages.NewsCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly ZeelandZoo.Data.ApplicationDbContext _context;

        public DetailsModel(ZeelandZoo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public News News { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.News == null)
            {
                return NotFound();
            }

            var news = await _context.News.FirstOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }
            else 
            {
                News = news;
            }
            return Page();
        }
    }
}
