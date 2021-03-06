﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MHS2019Demo.Models;

namespace MHS2019Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MHS2019Demo.Models.myDataContext _context;

        public IndexModel(MHS2019Demo.Models.myDataContext context)
        {
            _context = context;
        }

        public IList<Feedback> Feedback { get;set; }

        public async Task OnGetAsync()
        {
            Feedback = await _context.Feedback.ToListAsync();
        }
    }
}
