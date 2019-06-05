using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class CheckDataModel : PageModel
    {
        public string Naam { get; set; }

        public string BSN { get; set; }

        public string Antecedent { get; set; }

        public string Aanhoudingen { get; set; }

        public string Straf { get; set; }

        public string Uitkering { get; set; }

        public string Traject { get; set; }
    }
}
