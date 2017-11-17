using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trials4Health.Models;
using Microsoft.EntityFrameworkCore;

namespace Trials4Health.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Trilho> Trilhos { get; set; }
    }
}
