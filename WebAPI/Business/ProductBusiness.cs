using WebAPI.Contracts;
using WebAPI.Models;

namespace WebAPI.Business;

public class ProductBusiness: IProductBusiness
{
    static public List<Product> Products = new List<Product>()
    {
        new Product() { Id = 1, Name = "Test", Price = 10000, CreatedAt = DateTime.Now },
        new Product() { Id = 2, Name = "Test", Price = 12000, CreatedAt = DateTime.Now },
        new Product() { Id = 3, Name = "Test", Price = 13000, CreatedAt = DateTime.Now },
    };

    public List<Product> GetProducts()
    {
        return Products;
    }

    public Product GetProductById(int id)
    {
        var product = Products.Where(x => x.Id == id).FirstOrDefault();
        return product;
    }

    public bool AddProduct(Product product)
    {
        Products.Add(product);
        return true;
    }
}
