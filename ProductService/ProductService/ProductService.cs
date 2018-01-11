using System.Linq;

namespace ProductsLibrary
{
    public class ProductService : IProducts
    {
        public void AddNewProduct()
        {
            using (var products = new ProductsContext())
            {
                products.Products.Add(new Product() { ProductID = 1, ProductName = "C# 6 with Visual Studio", CategoryID = 2, CategoryName = "books", UnitInStock = 100 });
                products.SaveChanges();
            }
        }

        public string GetCategoryName(int productID)
        {
            using (var products = new ProductsContext())
            {
                return products.Products.FirstOrDefault(x => x.ProductID == productID)?.CategoryName;
            }
        }

        public string GetProductName(int productID)
        {
            using (var products = new ProductsContext())
            {
                return products.Products.FirstOrDefault(x => x.ProductID == productID)?.ProductName;
            }
        }

        public int? GetProductQty(int productID)
        {
            using (var products = new ProductsContext())
            {
                return products.Products.FirstOrDefault(x => x.ProductID == productID)?.UnitInStock;
            }
        }
    }
}
