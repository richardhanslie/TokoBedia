using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;
using TokoBeDia.Repositories;

namespace TokoBeDia.Handlers
{
    public class CheckoutHandler
    {
        public static void DoCheckout(int userId, int paymentId, DateTime date)
        {
            HeaderTransaction ht = TransactionRepository.InsertHeaderTransaction(userId, paymentId, date);

            List<Cart> c = CartRepository.GetAllCarts(userId);

            foreach(var item in c)
            {
                TransactionRepository.InsertDetailTransaction(ht.Id, item.ProductId, item.Quantity);
            }

            CartRepository.DeleteAllCarts(userId);
        }
    }
}