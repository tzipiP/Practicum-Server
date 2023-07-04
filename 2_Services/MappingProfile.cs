using _2_Services.Models;
using AutoMapper;
using PracticumServer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Child, ChildModel>().ReverseMap();

        }
    }
}
