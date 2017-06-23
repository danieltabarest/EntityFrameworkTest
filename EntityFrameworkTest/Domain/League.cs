using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class League
    {
        [Key]
        public int LeagueId{ get; set; }
        public int Name { get; set; }
        public int Log { get; set; }

        public virtual Collection<Team> Teams  { get; set; }
    }
}
