using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>>GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDto>> GetProductDetails();
        IDataResult<Product> GetById(int id);
        IDataResult<Product> GetByName(string name);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
        IResult TransactionalOperation(Product product);

    }
}
