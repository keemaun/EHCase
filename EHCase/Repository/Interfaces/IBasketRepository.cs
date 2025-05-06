using EHCase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHCase.Repository.Interfaces
{
    public interface IBasketRepository
    {
        Task<Basket> GetBasketAsync(string email);
        Task<Basket> GetBasketAsync(Guid uniqueID);
    }
}
