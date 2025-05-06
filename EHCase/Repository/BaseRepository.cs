using EHCase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHCase.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
    {
        public async Task<T> GetAsync(string sql, params (string key, object value)[] parameters)
        {
            // call database to get the data
            T result = default(T);
            return result;
        }

        public async Task<List<T>> GetListAsync(string sql, params (string key, object value)[] parameters)
        {
            // call database to get the data
            List<T> result = new List<T>();
            return await Task.FromResult(result);
        }
    }
}
