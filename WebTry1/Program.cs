// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductManager manager=new ProductManager(new EfProductDal());
foreach (var product in manager.GetProductDetails())
{
    Console.WriteLine(product.ProductName+" "+product.CategoryName);
}

