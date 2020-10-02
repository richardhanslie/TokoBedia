using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;
using TokoBeDia.Repositories;

namespace TokoBeDia.Handlers
{
    public class TransactionHandler
    {
        public static List<ViewHeaderTransactionMemberModel> GetHeaderTransactionByUserId(int userId)
        {
            List<ViewHeaderTransactionMemberModel> ht = TransactionRepository.GetHeaderTransactionByUserId(userId);
            return ht;
        }

        public static List<ViewHeaderTransactionModel> GetAllHeaderTransaction()
        {
            List<ViewHeaderTransactionModel> ht = TransactionRepository.GetAllHeaderTransaction();
            return ht;
        }

        public static List<ViewTransactionHistoryModel> GetDetailTransaction(int transactionId)
        {
            List<ViewTransactionHistoryModel> th = TransactionRepository.GetDetailTransaction(transactionId);
            return th;
        }
    }
}