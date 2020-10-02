using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factories;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;

namespace TokoBeDia.Repositories
{
    public class ProductRepository
    {
        public static TokoBeDiaEntities db = new TokoBeDiaEntities();

        public static List<ViewProductModel> GetAllProducts()
        {
            List<ViewProductModel> products;
            products = (from a in db.Products select 
                        new ViewProductModel {
                            ProductID = a.Id,
                            ProductName = a.Name,
                            ProductStock = a.Stock,
                            ProductPrice = a.Price,
                            ProductType = a.ProductType.Name
                        }).ToList();

            return products;
        }

        public static Product InsertProduct(int productType, string name, int price, int stock)
        {
            Product p = ProductFactory.GetProduct(productType, name, price, stock);

            db.Products.Add(p);
            db.SaveChanges();

            return p;
        }

        public static Product GetProductId(int id)
        {
            Product p = (from a in db.Products where a.Id == id select a).FirstOrDefault();
            return p;
        }

        public static Product UpdateProduct(int id, string name, int price, int stock, int productType)
        {
            Product product = GetProductId(id);
            product.Name = name;
            product.Price = price;
            product.Stock = stock;
            product.ProductTypeId = productType;

            db.SaveChanges();
            return product;
        }

        public static Product DeleteProduct(int id)
        {
            try
            {
                Product p = GetProductId(id);
                db.Products.Remove(p);
                db.SaveChanges();

                return p;
            }
            catch
            {
                return null;
            }
        }
    }
}