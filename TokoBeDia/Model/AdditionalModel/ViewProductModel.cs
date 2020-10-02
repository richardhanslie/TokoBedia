using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Model.AdditionalModel
{
    public class ViewProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public string ProductType { get; set; }
        public int ProductPrice { get; set; }
    }
}