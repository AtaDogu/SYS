using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,SysContext>,IProductDal
    {
        public List<ProductDto> GetProductDetails()
        {
            using (SysContext context=new SysContext())
            {
                var result = from p in context.Products
                    join c in context.Categories on p.CategoryId equals c.CategoryId
                    select new ProductDto
                    {
                        ProductId = p.ProductId, CategoryName = c.CategoryName,
                        ProductName = p.ProductName, UnitsInStock = p.UnitsInStock
                    };
                return result.ToList();
            }
        }
    }
}
