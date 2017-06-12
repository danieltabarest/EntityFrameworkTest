using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DateContext : DbContext
    {
        public DateContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Domain.League> Leagues { get; set; }
    }
}
