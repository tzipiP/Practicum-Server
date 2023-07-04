using Microsoft.EntityFrameworkCore;
using PracticumServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Interfaces
{
    public interface IDataSource
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
       public DbSet<User> users { get; set; }
       public DbSet<Child> children { get; set; }
    }
}
