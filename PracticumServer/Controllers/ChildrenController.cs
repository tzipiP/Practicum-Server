using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Repository.Interfaces;
using _2_Services.Models;
using _2_Services.ServiceClasses;
using _3_Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticumServer.Models;

namespace PracticumServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        IChildSer _service;
   

        public ChildrenController(IChildSer service)
        {
            _service = service;

        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<ChildModel>> Get()
        {
            return await _service.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<ChildModel> Get(int id)
        {
            return await _service.GetById(id);
        }
        // post api/<UserController>
    
        [HttpPost]
        public async Task<ChildModel> post([FromBody] ChildModel child)
        {
            if (!ModelState.IsValid)
            {
                BadRequest();
            }
           return await _service.Add(child);
        }
        // put api/<UserController>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] ChildModel child)
        {
            if (!ModelState.IsValid)
            {
                BadRequest();
            }
            await _service.Update(child);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _service.Delete(id);
        }
    }
}

