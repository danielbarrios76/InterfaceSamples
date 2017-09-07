using System.Collections.Generic;
using System.Linq;
using ProductInterface;

namespace DAL
{
    public class Product : IProduct
    {
        public Entities.Product GetProductByID (int ID)
        {          
            return Products.Where(x => x.ProductID == ID).FirstOrDefault();
        }

        List<Entities.Product> Products = new List<Entities.Product>
        {
            new Entities.Product
            {
                ProductID = 1,
                ProductName = "Azucar",
                UnitPrice = 12,
                UnitsInStock = 100,
                CategoryID = 1
            },
            new Entities.Product
            {
                ProductID = 2,
                ProductName = "Frijol",
                UnitPrice = 23,
                UnitsInStock = 200,
                CategoryID = 2
            },
            new Entities.Product
            {
                ProductID = 3,
                ProductName = "Leche",
                UnitPrice = 127,
                UnitsInStock = 1000,
                CategoryID = 3
            },

        };
    }
}
