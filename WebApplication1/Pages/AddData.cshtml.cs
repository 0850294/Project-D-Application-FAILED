using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class AddDataModel : PageModel
    {
        [Required]
        [MaxLength(256)]
        [Display(Name = "Naam")]
        public string Naam { get; set; }

        [Required]
        [MaxLength(16)]
        [Display(Name = "BSN")]
        public string BSN { get; set; }

        [Required]
        [MaxLength(1024)]
        [Display(Name = "Antecedent")]
        public string Antecedent { get; set; }

        [Required]
        [MaxLength(16)]
        [Display(Name = "Aanhoudingen")]
        public string Aanhoudingen { get; set; }

        [Required]
        [MaxLength(256)]
        [Display(Name = "Straf")]
        public string Straf { get; set; }

        [Required]
        [MaxLength(8)]
        [Display(Name = "Uitkering")]
        public string Uitkering { get; set; }

        [Required]
        [MaxLength(8)]
        [Display(Name = "Traject")]
        public string Traject { get; set; }
    }
}
