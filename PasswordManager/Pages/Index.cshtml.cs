using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace PasswordManager.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            //ViewData["Message"] = "My key val = " + _configuration["mongocustomerprofile"];
        }
        private static IConfiguration _configuration;
        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
