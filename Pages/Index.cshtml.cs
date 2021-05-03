using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BOP.Pages
{
    public class IndexModel : PageModel
    {
        private Double pingTime;
        
        
        public static String GraphTitle = "UWU";

        
        public void OnGet()
        {
            
            return;
        }
    }
}