using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factories;
using TokoBeDia.Model;

namespace TokoBeDia.Repositories
{
    public class ProductTypeRepository
    {
        public static TokoBeDiaEntities db = new TokoBeDiaEntities();

        public static List<ProductType> GetAllProductsType()
        {
            List<ProductType> products;
            products = (from a in db.ProductTypes select a).ToList();

            return products;
        }

        public static ProductType InsertProductType(string name, string desc)
        {
            ProductType pt = ProductTypeFactory.GetProductType(name, desc);
            db.ProductTypes.Add(pt);
            db.SaveChanges();
            return pt;
        }

        public static ProductType GetProductTypeId(int id)
        {
            ProductType pt = (from a in db.ProductTypes where a.Id == id select a).FirstOrDefault();

            return pt;
        }

        public static ProductType UpdateProductType(int id, string name, string desc)
        {
            ProductType pt = GetProductTypeId(id);
            pt.Name = name;
            pt.Description = desc;

            db.SaveChanges();
            return pt;
        }

        public static ProductType DeleteProductType(int id)
        {
            try
            {
                ProductType pt = GetProductTypeId(id);
                db.ProductTypes.Remove(pt);
                db.SaveChanges();

                return pt;
            }
            catch
            {
                return null;
            }
        }

        public static ProductType GetProductTypeName(string name)
        {
            ProductType pt = (from a in db.ProductTypes where a.Name == name select a).FirstOrDefault();
            return pt;
        }
    }
}