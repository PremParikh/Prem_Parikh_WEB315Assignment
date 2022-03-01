#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesbooks.Models;

namespace RazorPagesbooks.Pages_Books{
#pragma warning disable CS8618
#pragma warning disable CS8604

    public class IndexModel : PageModel
    {
        private readonly RazorPagesBookContext _context;

        public IndexModel(RazorPagesBookContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
