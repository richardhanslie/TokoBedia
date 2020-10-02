using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;
using TokoBeDia.Repositories;

namespace TokoBeDia.Handlers
{
    public class ProductTypeHandler
    {
        public static ProductType GetName(string name)
        {
            ProductType pt = ProductTypeRepository.GetProductTypeName(name);
            return pt;
        }

        public static ProductType InsertProductType(string name, string desc)
        {
            ProductType pt = ProductTypeRepository.InsertProductType(name, desc);
            return pt;
        }

        public static ProductType UpdateProductType(int id, string name, string desc)
        {
            ProductType pt = ProductTypeRepository.UpdateProductType(id, name, desc);
            return pt;
        }

        public static List<ProductType> GetAllProductTypes()
        {
            List<ProductType> pt = ProductTypeRepository.GetAllProductsType();
            return pt;
        }

        public static ProductType DeleteProductType(int id)
        {
            ProductType pt = ProductTypeRepository.DeleteProductType(id);

            if(pt == null)
            {
                return null;
            }

            return pt;
        }

        public static ProductType GetProductTypeById(int id)
        {
            ProductType pt = ProductTypeRepository.GetProductTypeId(id);
            return pt;
        }
    }
}