using System.ServiceModel;

namespace ProductsLibrary
{
    [ServiceContract]
    public interface IProducts
    {
        [OperationContract]
        string GetProductName(int productID);

        [OperationContract]
        int? GetProductQty(int productID);

        [OperationContract]
        string GetCategoryName(int productID);

        [OperationContract]
        void AddNewProduct();
    }
}
