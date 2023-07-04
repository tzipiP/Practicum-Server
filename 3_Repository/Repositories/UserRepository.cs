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
    public class UserRepository : IUserRepository
    {
        private readonly IDataSource dataSource;

        public UserRepository(IDataSource ds)
        {
            dataSource = ds;
        }

        public async Task<User> Add(User model)
        {


            EntityEntry<User> newUser = await dataSource.users.AddAsync(model);
            await dataSource.SaveChangesAsync();
            return newUser.Entity;
            // List <Child> children = model.Children.ToList();


            //var result = await dataSource.users.AddAsync(model);
            //await dataSource.SaveChangesAsync();


            //foreach (var item in model.Children)
            //{
            //    //item.Father = result.Entity;
            //   item.FatherId = result.Entity.Id;
            //    dataSource.children.Add(item);
            //    await dataSource.SaveChangesAsync();
            //}
            //return model;
        }
        public async Task Delete(int id)
        {
            dataSource.users.Remove(await dataSource.users.FindAsync(id));
            dataSource.SaveChangesAsync();
        }

        public async Task<List<User>> GetAll()
        {
            //foreach (var u in dataSource.users)
            //{
            //    foreach (var c in dataSource.children)
            //    {
            //        if (c.FatherId == u.Id)
            //        {
            //          u.Children.Add(c);
            //           // u.Children.Remove(c);
            //        }

            //    }
            //}
            return await dataSource.users.ToListAsync();
        }

        public async Task<User> GetById(int key)
        {
            return await dataSource.users.FirstOrDefaultAsync(p => p.Id == key);
        }


        public async Task Update(User u)
        {
            dataSource.users.Update(u);
            await dataSource.SaveChangesAsync();
        }
    }
}
