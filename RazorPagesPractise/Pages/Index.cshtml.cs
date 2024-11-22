using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPractise.Models;

namespace RazorPagesPractise.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly RazorPagesPractise.Data.RazorPagesPractiseContext _context;

        public IndexModel(ILogger<IndexModel> logger, RazorPagesPractise.Data.RazorPagesPractiseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
        public async Task<IActionResult> OnGetDeleteBookAsync(int id)
        {
            var book = await _context.Book.FindAsync(id);

            if (book == null) return NotFound();

            _context.Book.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
