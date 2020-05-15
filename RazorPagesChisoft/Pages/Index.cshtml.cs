using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesChisoft.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public string City { get; set; }

        [BindProperty(SupportsGet =true)]
        public string State { get; set; }
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(City))
            {
                City = "The Web.";
                
            }

            if(string.IsNullOrWhiteSpace(State))
            {
                State = "ASP.NET RazorPages";
            }
        }
    }
}
