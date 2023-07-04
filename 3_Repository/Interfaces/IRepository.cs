using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Interfaces
{
    public interface IRepositpry<T>
    {
        Task<List<T>> GetAll();

        Task<T> GetById(int id);

        Task<T> Add(T item);

        Task Update(T item);

        Task Delete(int id);

    }
}
