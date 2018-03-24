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
        public bool Name1Attending { get; set; }
        [Display(Name = "Navn på følge")]
        public string Name2 { get; set; }
        [Display(Name = "Kommer du?")]
        public bool Name2Attending { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Kommentar")]
        public string Comment { get; set; }
    }
}
