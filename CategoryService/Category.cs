
using System.ComponentModel.DataAnnotations.Schema;

namespace CategoriesLibrary
{
    public class Category
    {
        public Category()
        {

        }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}