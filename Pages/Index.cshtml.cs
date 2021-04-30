using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BOP.Pages
{
    public class IndexModel : PageModel
    {
        
        public static String Message = "UWU";
        public string OnGet()
        {
           
            return Message;
        }
    }
}