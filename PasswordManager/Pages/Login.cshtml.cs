using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PasswordManager.Models;

namespace PasswordManager.Pages
{
    public class LoginModel : PageModel
    {
       [BindProperty]
        public CaptureLoginModel Logindetails { get; set; }
   

        public void OnGet()
        {
          
        }

        [HttpPost]
        public ActionResult OnPost()
        {
           

            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("Main");

        }
    }
}