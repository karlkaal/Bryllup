using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bryllup.Data
{
    public class Attendee
    {

        [Display(Name = "Brukernavn")]
        public string UserName { get; set; }
        [Display(Name = "Ditt navn")]
        public string Name1 { get; set; }
        [Display(Name = "Kommer du?")]
        public string Name1Attending { get; set; }
        [Display(Name = "Navn på følge")]
        public string Name2 { get; set; }
        [Display(Name = "Kommer du?")]
        public string Name2Attending { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Kommentar (allergier f.eks.)")]
        public string Comment { get; set; }
        [Display(Name = "Telefon")]
        public string Phone2 { get; set; }
        [Display(Name = "Hvor mange kommer på Grand fredag før bryllupet")]
        public string Friday { get; set; }
        [Display(Name = "Hvor mange kommer på Bølgen & Moi dagen etter bryllupet")]
        public string Sunday { get; set; }
    }
}
