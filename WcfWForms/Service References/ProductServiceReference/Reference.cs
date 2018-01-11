﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfWForms.ProductServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductServiceReference.IProducts")]
    public interface IProducts {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetProductName", ReplyAction="http://tempuri.org/IProducts/GetProductNameResponse")]
        string GetProductName(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetProductName", ReplyAction="http://tempuri.org/IProducts/GetProductNameResponse")]
        System.Threading.Tasks.Task<string> GetProductNameAsync(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetProductQty", ReplyAction="http://tempuri.org/IProducts/GetProductQtyResponse")]
        System.Nullable<int> GetProductQty(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetProductQty", ReplyAction="http://tempuri.org/IProducts/GetProductQtyResponse")]
        System.Threading.Tasks.Task<System.Nullable<int>> GetProductQtyAsync(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetCategoryName", ReplyAction="http://tempuri.org/IProducts/GetCategoryNameResponse")]
        string GetCategoryName(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetCategoryName", ReplyAction="http://tempuri.org/IProducts/GetCategoryNameResponse")]
        System.Threading.Tasks.Task<string> GetCategoryNameAsync(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/AddNewProduct", ReplyAction="http://tempuri.org/IProducts/AddNewProductResponse")]
        void AddNewProduct();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/AddNewProduct", ReplyAction="http://tempuri.org/IProducts/AddNewProductResponse")]
        System.Threading.Tasks.Task AddNewProductAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetCategoryID", ReplyAction="http://tempuri.org/IProducts/GetCategoryIDResponse")]
        System.Nullable<int> GetCategoryID(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetCategoryID", ReplyAction="http://tempuri.org/IProducts/GetCategoryIDResponse")]
        System.Threading.Tasks.Task<System.Nullable<int>> GetCategoryIDAsync(int productID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsChannel : WcfWForms.ProductServiceReference.IProducts, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsClient : System.ServiceModel.ClientBase<WcfWForms.ProductServiceReference.IProducts>, WcfWForms.ProductServiceReference.IProducts {
        
        public ProductsClient() {
        }
        
        public ProductsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetProductName(int productID) {
            return base.Channel.GetProductName(productID);
        }
        
        public System.Threading.Tasks.Task<string> GetProductNameAsync(int productID) {
            return base.Channel.GetProductNameAsync(productID);
        }
        
        public System.Nullable<int> GetProductQty(int productID) {
            return base.Channel.GetProductQty(productID);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<int>> GetProductQtyAsync(int productID) {
            return base.Channel.GetProductQtyAsync(productID);
        }
        
        public string GetCategoryName(int productID) {
            return base.Channel.GetCategoryName(productID);
        }
        
        public System.Threading.Tasks.Task<string> GetCategoryNameAsync(int productID) {
            return base.Channel.GetCategoryNameAsync(productID);
        }
        
        public void AddNewProduct() {
            base.Channel.AddNewProduct();
        }
        
        public System.Threading.Tasks.Task AddNewProductAsync() {
            return base.Channel.AddNewProductAsync();
        }
        
        public System.Nullable<int> GetCategoryID(int productID) {
            return base.Channel.GetCategoryID(productID);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<int>> GetCategoryIDAsync(int productID) {
            return base.Channel.GetCategoryIDAsync(productID);
        }
    }
}
