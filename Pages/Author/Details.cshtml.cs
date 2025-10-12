using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Boca_Vlad_Gabriel_Lab2.Data;
using Boca_Vlad_Gabriel_Lab2.Models;

namespace Boca_Vlad_Gabriel_Lab2.Pages.Author
{
    public class DetailsModel : PageModel
    {
        private readonly Boca_Vlad_Gabriel_Lab2.Data.Boca_Vlad_Gabriel_Lab2Context _context;

        public DetailsModel(Boca_Vlad_Gabriel_Lab2.Data.Boca_Vlad_Gabriel_Lab2Context context)
        {
            _context = context;
        }

        public Models.Author Author { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else
            {
                Author = author;
            }
            return Page();
        }
    }
}
