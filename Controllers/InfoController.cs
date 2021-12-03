using Microsoft.AspNetCore.Mvc;
using MotoGP.Models;
using System.Collections.Generic;

namespace MotoGP.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult ListRaces()
        {
            ViewBag.BannerNr = 0;
            return View();
        }

        public IActionResult BuildMap()
        {
            Race race1 = new Race();
            Race race2 = new Race();
            Race race3 = new Race();

            race1.RaceID = 1;
            race2.RaceID = 2;
            race3.RaceID = 3;

            race1.X = 517;
            race2.X = 859;
            race3.X = 194;

            race1.Y = 19;
            race2.Y = 249;
            race3.Y = 428 ;

            race1.RaceID = 1;
            race2.RaceID = 2;
            race3.RaceID = 3;

            race1.Name = "Assen";
            race2.Name = "Losail Circuit";
            race3.Name = "Autódromo Termas de Río Hondo";

            List<Race> Races = new List<Race>();
            Races.Add(race1);
            Races.Add(race2);
            Races.Add(race3);
            ViewBag.Races = Races;

            ViewBag.BannerNr = 0;
            return View();
        }

        public IActionResult SelectRace()
        {
            ViewBag.BannerNr = 0;
            return View();
        }


    }
}
