using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebInstaller.Models.ViewModels;

namespace WebInstaller.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public DatabaseInformation DatabaseInformation { get; set; } = new DatabaseInformation();


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostAsync()
        {
            Console.WriteLine(DatabaseInformation.ServerName);
            return RedirectToPage("Index");
        }
    }
}
