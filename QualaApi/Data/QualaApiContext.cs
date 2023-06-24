using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QualaApi.Models;

namespace QualaApi.Data
{
    public class QualaApiContext : DbContext
    {
        public QualaApiContext (DbContextOptions<QualaApiContext> options)
            : base(options)
        {
        }

        public DbSet<QualaApi.Models.Sucursal> Sucursal { get; set; } = default!;

        public DbSet<QualaApi.Models.ListMonedasClass>? ListMonedasClass { get; set; }
    }
}
