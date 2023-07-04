using _2_Repository.Interfaces;
using _2_Services.Models;
using _3_Repository.Interfaces;
using AutoMapper;
using PracticumServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.ServiceClasses
{
    public class UserService : IUserSer
    {

        IUserRepository rep;
        IMapper map;


        public UserService(IUserRepository _rep, IMapper _map)
        {
            rep = _rep;
            map = _map;
        }

        //public async Task<UserModel> Add(UserModel user)
        //{
        //    return  map.Map<UserModel>( rep.Add(map.Map<User>(user)));
        //}
        public async Task<UserModel> Add(UserModel user)
        {
            return map.Map<UserModel>(await rep.Add(map.Map<User>(user)));

        }
        public async Task Delete(int key)
        {
            await rep.Delete(key);
        }

        public async Task<IEnumerable<UserModel>> GetAll()
        {
            return map.Map<List<UserModel>>(await rep.GetAll());
        }


        public async Task<UserModel> GetById(int key)
        {
            return await map.Map<Task<UserModel>>( await rep.GetById(key));

        }


        public async Task Update(UserModel user)
        {
            await rep.Update(map.Map<User>(user));
        }
    }
}