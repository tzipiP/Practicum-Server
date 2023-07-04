using _3_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using PracticumServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository
{
    public class SqlDataSource : DbContext, IDataSource
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //optionBuilder.UseSqlServer(@"Data Source=DESKTOP-1BM6KB1;Initial Catalog=PracticumDB;Integrated Security=True; TrustServerCertificate=True;MultipleActiveResultSets=true");
            optionBuilder.UseSqlServer(@"Data Source=sqlsrv;;Initial Catalog=Practicum_DB;Integrated Security=True; TrustServerCertificate=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionBuilder);
        }
       
        public DbSet<User> users { get; set; }
        public DbSet<Child> children { get; set; }


    }


}
