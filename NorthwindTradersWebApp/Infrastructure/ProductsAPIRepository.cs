using NorthwindModelClassLibrary;
using ProductsAPIService.Infrastructure;

namespace NorthwindTradersWebApp.Infrastructure
{
    public class ProductsAPIRepository : IRepository<Product>
    {

        public void CreateNew(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
