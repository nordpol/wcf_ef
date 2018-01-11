using CategoriesLibrary;

namespace ProductsLibrary
{
    public class Product
    {
        public Product()
        {
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitInStock { get; set; }
        public Category Category { get; set; }
    }
}
