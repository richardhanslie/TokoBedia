using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factories;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;

namespace TokoBeDia.Repositories
{
    public class TransactionRepository
    {
        public static TokoBeDiaEntities db = new TokoBeDiaEntities();

        public static HeaderTransaction InsertHeaderTransaction(int userId, int paymentTypeId, DateTime date)
        {
            HeaderTransaction ht = TransactionFactory.GetHeaderTransaction(userId, paymentTypeId, date);
            db.HeaderTransactions.Add(ht);
            db.SaveChanges();

            return ht;
        }

        public static DetailTransaction InsertDetailTransaction(int transactionId, int productId, int qty)
        {
            DetailTransaction dt = TransactionFactory.GetDetailTransaction(transactionId, productId, qty);
            db.DetailTransactions.Add(dt);
            db.SaveChanges();

            return dt;
        }

        public static List<ViewHeaderTransactionMemberModel> GetHeaderTransactionByUserId(int userId)
        {
            List<ViewHeaderTransactionMemberModel> ht = (from a in db.HeaderTransactions where a.UserId == userId select 
                                          new ViewHeaderTransactionMemberModel()
                                          {
                                              Id = a.Id,
                                              PaymentType = a.PaymentType.Type,
                                              Date = a.Date.ToString()
                                          }).ToList();
            return ht;
        }

        public static List<ViewHeaderTransactionModel> GetAllHeaderTransaction()
        {
            List<ViewHeaderTransactionModel> ht = (from a in db.HeaderTransactions select 
                                          new ViewHeaderTransactionModel()
                                          {
                                              Id = a.Id,
                                              UserId = a.UserId,
                                              Email = a.User.Email,
                                              PaymentType = a.PaymentType.Type,
                                              Date = a.Date.ToString()
                                          }).ToList();
            return ht;
        }

        public static List<ViewTransactionHistoryModel> GetDetailTransaction(int transactionId)
        {
            List<ViewTransactionHistoryModel> th = (from a in db.DetailTransactions where a.TransactionId == transactionId select
                                                    new ViewTransactionHistoryModel()
                                                    {
                                                        TransactionDate = a.HeaderTransaction.Date.ToString(),
                                                        PaymentType = a.HeaderTransaction.PaymentType.Type,
                                                        ProductName = a.Product.Name,
                                                        Quantity = a.Quantity,
                                                        Subtotal = a.Product.Price * a.Quantity
                                                    }).ToList();
            return th;
        } 
    }
}