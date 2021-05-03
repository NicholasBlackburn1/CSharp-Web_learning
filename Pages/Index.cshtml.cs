using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BOP.Pages
{
    public class IndexModel : PageModel
    {
        
        public static String GraphTitle = "UWU";
        public static Double Visits = 0;
        public string OnGet()
        {
            
            return GraphTitle;
        }
    }
}