using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPractise.Data;
using RazorPagesPractise.Models;

namespace RazorPagesPractise.Pages
{
    public class BookListModel : PageModel
    {
        private readonly RazorPagesPractise.Data.RazorPagesPractiseContext _context;

        public BookListModel(RazorPagesPractise.Data.RazorPagesPractiseContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
