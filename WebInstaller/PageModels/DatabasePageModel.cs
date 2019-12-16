using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebInstaller.Models.ViewModels;

namespace WebInstaller.PageModels
{
    public class DatabasePageModel
    {
        [BindProperty]
        public DatabaseInformation DatabaseInformation { get; set; } = new DatabaseInformation();
    }
}
