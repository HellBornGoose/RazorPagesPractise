using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesPractise.Models;

namespace RazorPagesPractise.Data
{
    public class RazorPagesPractiseContext : DbContext
    {
        public RazorPagesPractiseContext (DbContextOptions<RazorPagesPractiseContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesPractise.Models.Book> Book { get; set; } = default!;
    }
}
