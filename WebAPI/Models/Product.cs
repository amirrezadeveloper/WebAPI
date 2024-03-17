using WebAPI.Contracts;

namespace WebAPI.Models;

public class Product:BaseEntity<int>
{

    public string Name { get; set; }
    public decimal Price { get; set; }

}
