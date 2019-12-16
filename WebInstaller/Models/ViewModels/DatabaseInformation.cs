using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebInstaller.Models.ViewModels
{
    public class DatabaseInformation
    {
        public string ServerName { get; set; }

        public string DatabaseName { get; set; }

        public string  ServerUserName { get; set; }

        public string ServerPassword { get; set; }

        public string ServerPort { get; set; }
    }
}
