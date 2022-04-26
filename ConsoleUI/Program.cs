using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + "/" + item.CategoryName);
                }
                Console.Write(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
            Console.ReadKey();
            //ProductTest();

            // CategoryTest();

        }

        private static void CategoryTest()
        {
            //IoC ? 
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            
           
        }
    }
}
