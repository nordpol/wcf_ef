using System.Linq;
using System;

namespace CategoriesLibrary
{
    class CategoryService : ICategory
    {
        public void AddNewCategory()
        {
            using (var categories = new CategoriesContext())
            {
                categories.Categories.Add(new Category() { CategoryID = 1, CategoryName = "Test" });
                categories.SaveChanges();
            }
        }

        public int? GetCategoryID(int categoryID)
        {
            using (var categories = new CategoriesContext())
            {
                return categories.Categories.FirstOrDefault(x => x.CategoryID == categoryID)?.CategoryID;
            }
        }

        public string GetCategoryName(int categoryID)
        {
            using (var categories = new CategoriesContext())
            {
                return categories.Categories.FirstOrDefault(x => x.CategoryID == categoryID)?.CategoryName;
            }
        }
    }
}
