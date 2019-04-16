using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MHS2019Demo.Models;

namespace MHS2019Demo.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly MHS2019Demo.Models.myDataContext _context;

        public DetailsModel(MHS2019Demo.Models.myDataContext context)
        {
            _context = context;
        }

        public Feedback Feedback { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Feedback = await _context.Feedback.FirstOrDefaultAsync(m => m.Id == id);

            if (Feedback == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
