using System.Data.Entity;

namespace ProductsLibrary
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("wcf")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
