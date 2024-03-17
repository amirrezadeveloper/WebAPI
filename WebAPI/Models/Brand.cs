using WebAPI.Contracts;

namespace WebAPI.Models
{
    public class Brand : BaseEntity<short>
    {
        public string Name { get; set; }
    }
}
