using EHCase.Model;
using EHCase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHCase.Repository
{
    public class BasketLineRepository : BaseRepository<Basket>, IBasketRepository
    {
        public async Task<Basket> GetBasketAsync(string email)
        {
            string sql = "SELECT * FROM Basket WHERE UserEmail = @UserEmail";

            return await base.GetAsync(sql, ("UserEmail", email));
        }

        public async Task<Basket> GetBasketAsync(Guid uniqueID)
        {
            string sql = "SELECT * FROM Basket WHERE UniqueID = @UniqueID";

            return await base.GetAsync(sql, ("UniqueID", uniqueID));
        }
    }
}
