using _3_Repository.Interfaces;
using _3_Repository;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_Services.Models;
using _3_Repository.Repositories;
using PracticumServer.Models;
using Microsoft.AspNetCore.Http;

namespace _2_Services
{
    public static class utilities
    {
        public static IServiceCollection AddRepoDependencies(this IServiceCollection services)
        {
          
            //להוסיף לכל מחלקה!!!
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IChildRepository, ChildRepository>();
           // services.AddScoped<IDataSource, SqlDataSource>();



            MapperConfiguration config = new MapperConfiguration(
         conf =>
         {
             conf.CreateMap<User, UserModel>().ReverseMap();
             conf.CreateMap<Child, ChildModel>().ReverseMap();
         });

            IMapper mapper = config.CreateMapper();

       

            services.AddSingleton(mapper);

           services.AddDbContext<IDataSource, SqlDataSource>();



            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            return services;
        }

    }
}
