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
        private BowlingLeagueDbContext _repo { get; set; }

        // Constructor
        public TeamsViewComponent (BowlingLeagueDbContext temp)
        {
            _repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["teamName"];
            return View(_repo.Teams.Distinct().OrderBy(x => x));
        }
    }
}
