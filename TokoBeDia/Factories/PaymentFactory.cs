using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factories
{
    public class PaymentFactory
    {
        public static PaymentType GetPaymentType(string type)
        {
            PaymentType pt = new PaymentType
            {
                Type = type
            };

            return pt;
        }
    }
}