using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handlers;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;

namespace TokoBeDia.Controllers
{
    public class TransactionController
    {
        public static List<ViewHeaderTransactionMemberModel> GetHeaderTransactionByUserId(int userId)
        {
            List<ViewHeaderTransactionMemberModel> ht = TransactionHandler.GetHeaderTransactionByUserId(userId);
            return ht;
        }

        public static List<ViewHeaderTransactionModel> GetAllHeaderTransaction()
        {
            List<ViewHeaderTransactionModel> ht = TransactionHandler.GetAllHeaderTransaction();
            return ht;
        }

        public static List<ViewTransactionHistoryModel> GetDetailTransaction(int transactionId)
        {
            List<ViewTransactionHistoryModel> th = TransactionHandler.GetDetailTransaction(transactionId);
            return th;
        }
    }
}