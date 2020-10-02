using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factories
{
    public class TransactionFactory
    {
        public static HeaderTransaction GetHeaderTransaction(int userId, int paymentId, DateTime date)
        {
            HeaderTransaction ht = new HeaderTransaction()
            {
                UserId = userId,
                PaymentTypeID = paymentId,
                Date = date
            };

            return ht;
        }

        public static DetailTransaction GetDetailTransaction(int transactionId, int productId, int qty)
        {
            DetailTransaction dt = new DetailTransaction()
            {
                TransactionId = transactionId,
                ProductId = productId,
                Quantity = qty
            };

            return dt;
        }
    }
}