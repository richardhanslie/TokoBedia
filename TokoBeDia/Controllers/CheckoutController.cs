using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handlers;

namespace TokoBeDia.Controllers
{
    public class CheckoutController
    {
        public static void DoCheckout(int userId, int paymentId, DateTime date)
        {
            CheckoutHandler.DoCheckout(userId, paymentId, date);
        }
    }
}