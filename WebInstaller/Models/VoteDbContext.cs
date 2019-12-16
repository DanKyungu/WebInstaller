using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebInstaller.Models.ViewModels;

namespace WebInstaller.Models
{
    public class VoteDbContext : DbContext
    {
        public DatabaseInformation DatabaseInformationConnect { get; set; }
        public string ConnectionString { get; set; }
        public DbSet<Electeur> Electeurs { get; set; }

        public VoteDbContext(DatabaseInformation databaseInformation)
        {
            DatabaseInformationConnect = databaseInformation;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL($"server={DatabaseInformationConnect.ServerName}" +
        //        $";database={DatabaseInformationConnect.DatabaseName};user={DatabaseInformationConnect.ServerUserName}" +
        //        $";password={DatabaseInformationConnect.ServerPassword}");
        //}


    }
}
