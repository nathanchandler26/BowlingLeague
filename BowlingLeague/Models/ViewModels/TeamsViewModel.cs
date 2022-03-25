using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Models.ViewModels
{
    public class TeamsViewModel
    {
        public IQueryable<Team> Teams { get; set; }

    }
    
    public class ViewModel
    {
        public Bowler Bowlers { get; set; }
        public Team Teams { get; set; }
    }
}
