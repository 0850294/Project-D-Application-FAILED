using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Pages;

namespace WebApplication1.Controllers
{
    public class AddBlockController : Controller
    {
        public IActionResult AddData()
        {
            return View();
        }

        public IActionResult AddData(AddDataModel ad)
        {
            var data = new blockdata
            {
                naam = ad.Naam,
                bsn = ad.BSN,
                antecedent = ad.Antecedent,
                aanhoudingen = ad.Aanhoudingen,
                straf = ad.Straf,
                uitkering = ad.Uitkering,
                traject = ad.Traject
            };

            return View();
        }

        public class blockdata
        {
            internal string naam;
            internal string bsn;
            internal string antecedent;
            internal string aanhoudingen;
            internal string straf;
            internal string uitkering;
            internal string traject;
        }
    }
}