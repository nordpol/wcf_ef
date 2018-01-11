
using System.ComponentModel.DataAnnotations.Schema;

namespace CategoriesLibrary
{
    public class Category
    {
        public Category()
        {

        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}