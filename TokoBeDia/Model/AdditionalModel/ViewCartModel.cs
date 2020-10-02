using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Model.AdditionalModel
{
    public class ViewCartModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int Subtotal { get; set; }
    }
}