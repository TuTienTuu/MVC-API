using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using Web.Data.Infrastructure;
using Web.Model.Models;

namespace Web.Data.Repositories
{
    public interface IProductRepository
    {

    }
  public  class ProductRepository : RepositoryBase<Product>,IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
