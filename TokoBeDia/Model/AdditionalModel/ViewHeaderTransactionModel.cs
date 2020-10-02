using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Model.AdditionalModel
{
    public class ViewHeaderTransactionModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string PaymentType { get; set; }
        public string Date { get; set; }
    }
}