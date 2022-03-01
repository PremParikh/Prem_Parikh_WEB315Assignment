#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesbooks.Models;

    public class RazorPagesBookContext : DbContext
    {
        public RazorPagesBookContext (DbContextOptions<RazorPagesBookContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesbooks.Models.Book> Book { get; set; }
    }
