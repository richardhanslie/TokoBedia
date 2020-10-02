using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factories
{
    public class ProductTypeFactory
    {
        public static ProductType GetProductType(string name, string desc)
        {
            ProductType pt = new ProductType()
            {
                Name = name,
                Description = desc
            };

            return pt;
        }
    }
}