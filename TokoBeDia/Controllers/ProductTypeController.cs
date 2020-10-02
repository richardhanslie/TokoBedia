using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handlers;
using TokoBeDia.Helpers;
using TokoBeDia.Model;

namespace TokoBeDia.Controllers
{
    public class ProductTypeController
    {
        public static Response InsertProductType(string name, string desc)
        {
            ProductType getName = ProductTypeHandler.GetName(name);

            if (name.Length < 5)
            {
                return new Response(false, "must consist of 5 characters or more");
            }
            else if (name == "")
            {
                return new Response(false, "must be filled");
            }
            else if (getName != null)
            {
                return new Response(false, "must be unique");
            }
            else if (desc == "")
            {
                return new Response(false, "must be filled");
            }
            else
            {
                ProductTypeHandler.InsertProductType(name, desc);
                return new Response(true);
            }
        }

        public static Response UpdateProductType(int id, string name,string desc)
        {
            ProductType getName = ProductTypeHandler.GetName(name);

            if (name.Length < 5)
            {
                return new Response(false, "must consist of 5 characters or more");
            }
            else if (name == "")
            {
                return new Response(false, "must be filled");
            }
            else if (getName != null)
            {
                return new Response(false, "must be unique");
            }
            else if (desc == "")
            {
                return new Response(false, "must be filled");
            }
            else
            {
                ProductTypeHandler.UpdateProductType(id, name, desc);
                return new Response(true);
            }
        }

        public static List<ProductType> GetAllProductTypes()
        {
            List<ProductType> pt = ProductTypeHandler.GetAllProductTypes();
            return pt;
        }

        public static Response DeleteProductType(int id)
        {
            ProductType pt = ProductTypeHandler.DeleteProductType(id);

            if (pt == null)
                return new Response(false, "to-be-delete product cannot be referenced in another table in the database");
            else
            {
                return new Response(true);
            }
        }

        public static ProductType GetProductTypeById(int id)
        {
            ProductType pt = ProductTypeHandler.GetProductTypeById(id);
            return pt;
        }
    }
}