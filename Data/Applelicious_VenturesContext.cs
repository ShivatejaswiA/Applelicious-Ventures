using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Applelicious_Ventures.Models;

namespace Applelicious_Ventures.Data
{
    public class Applelicious_VenturesContext : DbContext
    {
        public Applelicious_VenturesContext (DbContextOptions<Applelicious_VenturesContext> options)
            : base(options)
        {
        }

        public DbSet<Applelicious_Ventures.Models.Apple> Apple { get; set; } = default!;
    }
}
