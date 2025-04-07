using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAgile_Process.Models;

namespace MVCAgile_Process.Data
{
    public class MVCAgile_ProcessContext : DbContext
    {
        public MVCAgile_ProcessContext (DbContextOptions<MVCAgile_ProcessContext> options)
            : base(options)
        {
        }

        public DbSet<MVCAgile_Process.Models.Movie> Movie { get; set; } = default!;
    }
}
