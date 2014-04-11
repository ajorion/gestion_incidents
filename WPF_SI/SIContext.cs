using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WPF_SI
{
    class SIContext : DbContext
    {
        public DbSet<WPF_SI.dbEntities.interventions> interventions { get; set; }
    }
}
