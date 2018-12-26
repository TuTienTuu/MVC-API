using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using Web.Data.Infrastructure;
using Web.Model.Models;
using System.Linq;
using System.Collections.Generic;

namespace Web.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GeByAlias(string alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>,IProductCategoryRepository
    {
        public ProductCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GeByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
