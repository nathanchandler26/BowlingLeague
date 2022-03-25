using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BowlingLeague.Models;
using Microsoft.AspNetCore.Mvc;

namespace BowlingLeague.Components
{
    public class TeamsViewComponent : ViewComponent
    {
        private IBowlingLeagueRepository repo { get; set; }

        // Constructor
        public TeamsViewComponent (IBowlingLeagueRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            var teams = repo.Teams
                .Select(x => x.TeamName)
                .Distinct()
                .OrderBy(x => x);
            return View(teams);
        }
    }
}
