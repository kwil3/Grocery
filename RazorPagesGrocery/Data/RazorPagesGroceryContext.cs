using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesGrocery.Models;

    public class RazorPagesGroceryContext : DbContext
    {
        public RazorPagesGroceryContext (DbContextOptions<RazorPagesGroceryContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesGrocery.Models.Item> Item { get; set; } = default!;

        public DbSet<RazorPagesGrocery.Models.Customer>? Customer { get; set; }
    }
