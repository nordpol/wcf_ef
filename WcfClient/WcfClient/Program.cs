using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WcfClient.ConsoleCategoryServiceReference;
using WcfClient.ConsoleProductServiceReference;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ID: ");
            int id = Int32.Parse(Console.ReadLine());
            
            // Take a Category ID and name 
            CategoryClient client = new CategoryClient();
                client.Open();
                Console.WriteLine(client.GetCategoryID(id));
                Console.WriteLine("\r\n");
                Console.WriteLine(client.GetCategoryName(id));
            client.Close();

            ProductsClient productClient = new ProductsClient();
                productClient.Open();
                Console.WriteLine(productClient.GetCategoryName(id));
                Console.WriteLine("\r\n");
                Console.WriteLine(productClient.GetProductName(id));
                Console.WriteLine("\r\n");
                Console.WriteLine(productClient.GetProductQty(id));
                Console.WriteLine("\r\n");
                Console.WriteLine(productClient.GetCategoryID(id));
            productClient.Close();

            Console.ReadKey();
        }
    }
}
