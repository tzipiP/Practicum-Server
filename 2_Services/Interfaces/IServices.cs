using _2_Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Repository.Interfaces
{
    public interface IServices<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task<T> Add(T item);

        Task Update(T item);

        Task Delete(int id);

    }
}
