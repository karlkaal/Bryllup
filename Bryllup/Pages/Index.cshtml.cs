using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bryllup.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bryllup.Pages
{
    public class IndexModel : PageModel
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }
        public async Task<IActionResult> OnGet()
        {

            if (!_signInManager.IsSignedIn(User))
                return RedirectToPage("/StartRegistration");

            return Page();
        }
    }
}
