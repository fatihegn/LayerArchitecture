using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            // Hafızadaki hazır DB olarak kabul ediyoruz.
            _products = new List<Product> {
            new Product{ProductId=1,CategoryId=1,ProductName="Tea",UnitPrice=5,UnitsInStock=15},
            new Product{ProductId=2,CategoryId=1,ProductName="Coffe",UnitPrice=10,UnitsInStock=15},
            new Product{ProductId=3,CategoryId=1,ProductName="Water",UnitPrice=2,UnitsInStock=15},
            new Product{ProductId=4,CategoryId=2,ProductName="Muffin",UnitPrice=15,UnitsInStock=15},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete =
            _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p=>p.CategoryId==categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderilen ürün id'sine sahip ürünü listedeki ürünü bulmak . / Linq
            Product productToUpdate =
             _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }
    }
}
