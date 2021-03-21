using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Models;


namespace Tarea1.Back_End
{
    class ProductSC : BaseSC, IUpdate
    {

       public IQueryable<Product> GetProducts()
        {
            return dataContext.Products.AsQueryable();
        }

        public Product GetProductByName(String productName)
        {
            return GetProducts().Where(x => x.ProductName == productName).First();
        }
       
        public Product GetProductById(int id)
        {
            return GetProducts().Where(x => x.ProductId == id).First();
        }

        public void AddProduct(Product newProduct)
        {
            var newProductReg = new Product();
            newProductReg.ProductName = newProduct.ProductName;

            dataContext.Products.Add(newProductReg);
            dataContext.SaveChanges();
        }

        public void UpdateNameById(int id, string name)
        {
            var currentProduct = new ProductSC().GetProductById(id);
            currentProduct.ProductName = name;
            dataContext.Products.Update(currentProduct);
            dataContext.SaveChanges();
        }
    }
}