using System.Data.Entity;

namespace CategoriesLibrary
{
    public class CategoriesContext : DbContext
    {
        public CategoriesContext()
            : base("wcf")
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
