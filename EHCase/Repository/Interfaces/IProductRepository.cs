using EHCase.Model;
using EHCase.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHCase.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetTopXCheapestProductsAsync(int top);
        Task<List<Product>> GetTopXRankedProductsAsync(int top);
        Task<List<Product>> GetProductsByPriceAsync(int page, int itemsPerPage, SortOrder sortOrder);
    }
}
