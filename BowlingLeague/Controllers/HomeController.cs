using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BowlingLeague.Models;
using BowlingLeague.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BowlingLeague.Controllers
{
    public class HomeController : Controller
    {

        private IBowlingLeagueRepository _repo { get; set; }

        // Constructor
        public HomeController(IBowlingLeagueRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(string teamName) // Maybe change this to team id?
        {
            var x = _repo.Bowlers
                //.Include(x => x.TeamID == _repo.Teams)
                //.Where(x => x.Team)
                .ToList();
            return View(x);
        }

        //var x = from b in _repo.Bowlers
        //        join t in _repo.Teams on b.TeamID equals t.TeamID into table1
        //        from t in table1.ToList()
        //        select new ViewModel
        //        {
        //            Bowlers = b,
        //            Teams = t
        //        };




        //public IActionResult Index(string teamName)
        //{
        //    var x = new TeamsViewModel
        //    {
        //        Bowlers = _repo.Bowlers

        //    }
        //    return View(x);
        //}

        [HttpGet]
        public IActionResult AddBowler()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBowler(Bowler b)
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditBowler()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditBowler(Bowler b)
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeleteBowler()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteBowler(Bowler b)
        {
            return View();
        }
    }
}

