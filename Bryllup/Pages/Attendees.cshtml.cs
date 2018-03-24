using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bryllup.Data;
using Microsoft.AspNetCore.Identity;

namespace Bryllup.Pages
{
    public class AttendeesModel : PageModel
    {
        private readonly BryllupDbContext db;
        private readonly SignInManager<ApplicationUser> signInManager;
        public AttendeesModel(BryllupDbContext db, SignInManager<ApplicationUser> signInManager)
        {
            this.db = db;
            this.signInManager = signInManager;
        }

        [BindProperty]
        public Attendee attendee { get; set; }

        public void OnGet()
        {
            if (signInManager.IsSignedIn(User))
            {
                var userName = User.Identity.Name;
                attendee = db.Attendee.SingleOrDefault(si => si.UserName ==  userName);

                if (attendee == null)
                {
                    Attendee a = new Attendee { UserName = userName, Name1Attending = true };

                    db.Add(a);

                    db.SaveChanges();
                }
            }
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (signInManager.IsSignedIn(User))
            {
                var userName = User.Identity.Name;
                var a = db.Attendee.SingleOrDefault(si => si.UserName == userName);

                a.Name1 = attendee.Name1;
                a.Name1Attending = attendee.Name1Attending;
                a.Name2 = attendee.Name2;
                a.Name2Attending = attendee.Name2Attending;
                a.Phone = attendee.Phone;
                a.Comment = attendee.Comment;

                db.SaveChanges();
            }


            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}