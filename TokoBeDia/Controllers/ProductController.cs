using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handlers;
using TokoBeDia.Helpers;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;

namespace TokoBeDia.Controllers
{
    public class ProductController
    {
        public static IEnumerable<ViewProductModel> GetFiveProduct()
        {
            var rand = new Random();
            IEnumerable<ViewProductModel> p = ProductHandler.GetAllProduct().OrderBy(x => rand.Next()).Take(5);
            return p;
        }

        public static Response InsertProduct(int productType, string name, int price, int stock)
        {
            ProductType pt = ProductTypeHandler.GetProductTypeById(productType);

            if (name == "")
                return new Response(false, "must be filled");
            else if (stock < 1)
                return new Response(false, "input must be 1 or more");
            else if (price < 1000)
                return new Response(false, "input must be above 1000");
            else if (price % 1000 != 0)
                return new Response(false, "input mus be multiply of 1000");
            else if (pt == null)
                return new Response(false, "product type does not exist");
            else
            {
                ProductHandler.InsertProduct(productType, name, price, stock);
                return new Response(true);
            }
        }

        public static Response UpdateProduct(int id, string name, int price, int stock, int productTypeId)
        {
            ProductType pt = ProductTypeHandler.GetProductTypeById(productTypeId);

            if (name == "")
                return new Response(false, "must be filled");
            else if (stock < 1)
                return new Response(false, "input must be 1 or more");
            else if (price < 1000)
                return new Response(false, "input must be above 1000");
            else if (price % 1000 != 0)
                return new Response(false, "input must be multiply of 1000");
            else if (pt == null)
                return new Response(false, "product type does not exist");
            else
            {
                ProductHandler.UpdateProduct(id, name, price, stock, productTypeId);
                return new Response(true);
            }
        }

        public static List<ViewProductModel> GetAllProducts()
        {
            List<ViewProductModel> p = ProductHandler.GetAllProduct();
            return p;
        }

        public static Response DeleteProduct(int id)
        {
            Product p = ProductHandler.DeleteProduct(id);

            if (p == null)
                return new Response(false, "to-be-deleted product cannot be referenced in another table in the database");
            else
                return new Response(true);
        }

        public static Product GetProduct(int id)
        {
            Product p = ProductHandler.GetProduct(id);
            return p;
        }
    }
}