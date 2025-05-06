using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHCase.Repository.Interfaces
{
    public interface IBaseRepository<T>
    {
        public Task<T> GetAsync(string sql, params (string key, object value)[] parameters);
    }
}
