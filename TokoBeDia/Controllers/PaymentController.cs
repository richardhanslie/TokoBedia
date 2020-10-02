using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handlers;
using TokoBeDia.Helpers;
using TokoBeDia.Model;

namespace TokoBeDia.Controllers
{
    public class PaymentController
    {
        public static Response InsertPaymentType(string type)
        {
            if (type == "")
                return new Response(false, "must be filled");
            if (type.Length < 3)
            {
                return new Response(false, "must consist of 3 characters or more");
            }
            else
            {
                Response respond = PaymentHandler.InsertPaymentType(type);
                return respond;
            }
        }

        public static List<PaymentType> GetAllPaymentTypes()
        {
            List<PaymentType> pt = PaymentHandler.GetAllPaymentTypes();
            return pt;
        }

        public static Response DeletePaymentType(int id)
        {
            PaymentType pt = PaymentHandler.DeletePaymentType(id);
            if (pt == null)
                return new Response(false, "to-be-deleted product cannot be referenced in another table in the database");
            else
                return new Response(true);
        }

        public static PaymentType GetPaymentTypeById(int id)
        {
            PaymentType pt = PaymentHandler.GetPaymentTypeById(id);
            return pt;
        }

        public static Response UpdatePaymentType(int id, string type)
        {
            if (type == "")
                return new Response(false, "must be filled");
            if (type.Length < 3)
            {
                return new Response(false, "must consist of 3 characters or more");
            }
            else
            {
                Response respond = PaymentHandler.UpdatePaymentType(id, type);
                return respond;
            }
        }
    }
}