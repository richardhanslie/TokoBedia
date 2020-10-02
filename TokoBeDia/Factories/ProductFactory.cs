using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factories
{
    public class ProductFactory
    {
        public static Product GetProduct(int productType, string name, int price, int stock)
        {
            Product p = new Product()
            {
                ProductTypeId = productType,
                Name = name,
                Price = price,
                Stock = stock
            };

            return p;
        }
    }
}