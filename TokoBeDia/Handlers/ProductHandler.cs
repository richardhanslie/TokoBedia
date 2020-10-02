using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;
using TokoBeDia.Repositories;

namespace TokoBeDia.Handlers
{
    public class ProductHandler
    {
        public static List<ViewProductModel> GetAllProduct()
        {
            List<ViewProductModel> p = ProductRepository.GetAllProducts();
            return p;
        }

        public static Product InsertProduct(int productType, string name, int price, int stock)
        {
            Product p = ProductRepository.InsertProduct(productType, name, price, stock);
            return p;
        }

        public static Product UpdateProduct(int id, string name, int price, int stock, int productType)
        {
            Product p = ProductRepository.UpdateProduct(id, name, price, stock, productType);
            return p;
        }

        public static Product DeleteProduct(int id)
        {
            Product p = ProductRepository.DeleteProduct(id);

            if (p == null)
                return null;

            return p;
        }

        public static Product GetProduct(int id)
        {
            Product p = ProductRepository.GetProductId(id);
            return p;
        }
    }
}