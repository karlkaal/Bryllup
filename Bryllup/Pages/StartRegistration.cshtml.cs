using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Bryllup.Data;

namespace Bryllup.Pages
{
    public class AboutModel : PageModel
    {

        public bool PasswordCorrect { get; set; }
        public string Message { get; set; }

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AboutModel(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }
        [BindProperty]
        public InputModel Input { get; set; }


        public class InputModel
        {
            public string Passord { get; set; }

            public bool CanAddend { get; set; }

            public string Name1 { get; set; }
            public string Name2 { get; set; }

        }

        public async Task<IActionResult> OnGet()
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToPage("/Attendees");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                if (Input.Passord == "Aladdin")
                {
                 

                   return RedirectToPage("Account/Register");
                }
                else
                {
                    Message = "Passordet er ikke riktig";
                }

            }
            else
            {
                Message = "Du må fylle ut passord";
            }
            

            // If we got this far, something failed, redisplay form
            return Page();
        }

    }
}
