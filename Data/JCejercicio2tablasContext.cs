using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JCejercicio2tablas.Models;

namespace JCejercicio2tablas.Data
{
    public class JCejercicio2tablasContext : DbContext
    {
        public JCejercicio2tablasContext (DbContextOptions<JCejercicio2tablasContext> options)
            : base(options)
        {
        }

        public DbSet<JCejercicio2tablas.Models.Burger> Burger { get; set; } = default!;

        public DbSet<JCejercicio2tablas.Models.Promo>? Promo { get; set; }
    }
}
