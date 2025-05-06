using EHCase.Model;
using EHCase.Repository.Interfaces;
using EHCase.Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace EHCase.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public Task<List<Product>> GetProductsByPriceAsync(int page, int itemsPerPage, SortOrder sortOrder)
        {
            Pagination pagination = new Pagination
            {
                Page = page,
                ItemsPerPage = itemsPerPage
            };

            string orderByClause = "ORDER BY Price " + (sortOrder == SortOrder.Asc ? "ASC" : "DESC");

            string sql = $@" SELECT * FROM Product {orderByClause}  OFFSET {pagination.Offset} ROWS FETCH NEXT {pagination.ItemsPerPage} ROWS ONLY";

            return base.GetListAsync(sql);
        }

        public async Task<List<Product>> GetTopXCheapestProductsAsync(int top)
        {            
            string sql = "SELECT TOP(@Top) * FROM Product ORDER BY Price ASC";

            return await base.GetListAsync(sql, ("Top", top));
        }
    }
}
