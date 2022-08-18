using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewStructure.Models;

namespace ViewStructure.Controllers
{
    public class JournalistController : Controller
    {

        List<Journalist> journalists = new List<Journalist>()
        {

            new Journalist(){JournalistId=1,Name="Oguzhan ",Gender="Erkek"},
            new Journalist(){JournalistId=2,Name="Yavuz ", Gender="Erkek" },
            new Journalist(){JournalistId=3,Name="Selin ",Gender="Kadin"},
            new Journalist(){JournalistId=4,Name="Alp",Gender="Erkek"},
            new Journalist(){JournalistId=5,Name="Ece",Gender="Kadin"}

        };

        public IActionResult GetJournaList()
        {
            return View(journalists);
        }

        public IActionResult DeleteJournalist(int id)
        {
            Journalist journalist = journalists.Find(n => n.JournalistId == id);
            return View(journalist);
        }


    }
}
