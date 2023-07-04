using _2_Repository.Interfaces;
using _2_Services.Models;
using _3_Repository.Interfaces;
using AutoMapper;
using PracticumServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.ServiceClasses
{
    public class ChildService : IChildSer
    {

        IChildRepository rep;
        IMapper map;


        public ChildService(IChildRepository _rep, IMapper _map)
        {
            rep = _rep;
            map = _map;
        }
        public async Task<ChildModel> Add(ChildModel child)
        {
            return map.Map<ChildModel>(await rep.Add(map.Map<Child>(child)));

        }
     

        public async Task Delete(int key)
        {
            await rep.Delete(key);
        }

        public async Task<IEnumerable<ChildModel>> GetAll()
        {
            return map.Map<List<ChildModel>>(await rep.GetAll());
        }

        public async Task<ChildModel> GetById(int key)
        {
            return await map.Map<Task<ChildModel>>(rep.GetById(key));

        }
        public async Task Update(ChildModel model)
        {
            await rep.Update(map.Map<Child>(model));

        }
    }
}