using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMerchandising.Models;

namespace MVCMerchandising.Data
{
    public class MVCMerchandisingContext : DbContext
    {
        public MVCMerchandisingContext (DbContextOptions<MVCMerchandisingContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMerchandising.Models.Merchandising> Merchandising { get; set; }
    }
}
