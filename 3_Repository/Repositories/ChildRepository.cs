using _3_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PracticumServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Repositories
{
    public class ChildRepository : IChildRepository
    {
        IDataSource dataSource;

        public ChildRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public async Task<Child> Add(Child child)
        {


            EntityEntry<Child> newUser = await dataSource.children.AddAsync(child);
            await dataSource.SaveChangesAsync();
            return newUser.Entity;
        
        }
     
        public async Task Delete(int key)
        {
            dataSource.children.Remove(await GetById(key));
            await dataSource.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAll()
        {
            return await dataSource.children.ToListAsync();
        }
        
        public async Task<Child> GetById(int key)
        {
            return await dataSource.children.FindAsync(key);
        }

        public async Task Update(Child model)
        {
            dataSource.children.Update(model);
            await dataSource.SaveChangesAsync();
        }
    }
}
