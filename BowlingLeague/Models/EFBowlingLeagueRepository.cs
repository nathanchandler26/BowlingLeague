using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Models
{
    public class EFBowlingLeagueRepository : IBowlingLeagueRepository
    {
        private BowlingLeagueDbContext context { get; set; }
        public EFBowlingLeagueRepository (BowlingLeagueDbContext temp)
        {
            context = temp;
        }
        public IQueryable<Bowler> Bowlers => context.Bowlers;

        public IQueryable<Team> Teams => context.Teams;

        public void AddBowler(Bowler b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBowler(Bowler b)
        {
            context.Remove(b);
            context.SaveChanges();
        }

        public void SaveBowler(Bowler b)
        {
            context.SaveChanges();
        }
    }
}
