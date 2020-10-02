using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Model.AdditionalModel
{
    public class ViewTransactionHistoryModel
    {
        public string TransactionDate { get; set; }
        public string PaymentType { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Subtotal { get; set; }
    }
}