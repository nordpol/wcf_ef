using System.ServiceModel;

namespace CategoriesLibrary
{
    [ServiceContract]
    public interface ICategory
    {
        [OperationContract]
        int? GetCategoryID(int categoryID);

        [OperationContract]
        string GetCategoryName(int categoryID);

        [OperationContract]
        void AddNewCategory();
    }
}
