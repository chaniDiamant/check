using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace check.Models
{
    public class checkContext : DbContext
    {
        public checkContext (DbContextOptions<checkContext> options)
            : base(options)
        {
        }

        public DbSet<check.Models.product> product { get; set; }
    }
}
