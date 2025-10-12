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
    public class IndexModel : PageModel
    {
        private readonly Boca_Vlad_Gabriel_Lab2.Data.Boca_Vlad_Gabriel_Lab2Context _context;

        public IndexModel(Boca_Vlad_Gabriel_Lab2.Data.Boca_Vlad_Gabriel_Lab2Context context)
        {
            _context = context;
        }

        public IList<Models.Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
