using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tataruca_Mihai_Lab2.Models;

namespace Tataruca_Mihai_Lab2.Data
{
    public class Tataruca_Mihai_Lab2Context : DbContext
    {
        public Tataruca_Mihai_Lab2Context (DbContextOptions<Tataruca_Mihai_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Tataruca_Mihai_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Tataruca_Mihai_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Tataruca_Mihai_Lab2.Models.Author>? Author { get; set; }
    }
}
