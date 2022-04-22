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
            Console.Write("Max Fiyata Göre Listele : ");
            int unitValue = Convert.ToInt32(Console.ReadLine());
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUnitPrice(unitValue))
            {
                Console.WriteLine("Max "+unitValue+" değerindeki ürünler.");
                Console.Write(item.ProductName);
                Console.WriteLine(" Fiyatı : "+item.UnitPrice);
            }
          
        }
    }
}
