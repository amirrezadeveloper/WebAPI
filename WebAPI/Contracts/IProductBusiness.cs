using WebAPI.Models;

namespace WebAPI.Contracts;

public interface IProductBusiness
{
    List<Product> GetProducts();
    Product GetProductById(int id);
    bool AddProduct(Product product);
}
