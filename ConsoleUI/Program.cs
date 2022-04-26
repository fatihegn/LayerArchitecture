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
            foreach (var item in productManager.GetProductDetails())
            {

                Console.WriteLine(item.ProductName + "/" + item.CategoryName);
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
            
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
               
                Console.WriteLine(item.ProductName+"/"+item.CategoryName);
            }
            Console.ReadKey();
        }
    }
}
