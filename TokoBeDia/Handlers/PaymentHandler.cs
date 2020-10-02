using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Helpers;
using TokoBeDia.Model;
using TokoBeDia.Repositories;

namespace TokoBeDia.Handlers
{
    public class PaymentHandler
    {
        public static Response InsertPaymentType(string type)
        {
            PaymentType getPayment = GetPaymentTypeByName(type);
            if(getPayment != null)
            {
                return new Response(false, "must be unique");
            }
            else
            {
                PaymentRepository.InsertPaymentType(type);
                return new Response(true);
            }
        }

        public static PaymentType DeletePaymentType(int id)
        {
            PaymentType pt = PaymentRepository.DeletePaymentType(id);
            if (pt == null)
                return null;
            return pt;
        }

        public static Response UpdatePaymentType(int id, string type)
        {
            PaymentType getPayment = GetPaymentTypeByName(type);
            if (getPayment != null)
            {
                return new Response(false, "must be unique");
            }
            else
            {
                PaymentRepository.UpdatePaymentType(id, type);
                return new Response(true);
            }
        }

        public static PaymentType GetPaymentTypeById(int id)
        {
            PaymentType pt = PaymentRepository.GetPaymentTypeById(id);
            return pt;
        }

        public static PaymentType GetPaymentTypeByName(string type)
        {
            PaymentType pt = PaymentRepository.GetPaymentTypeByName(type);
            return pt;
        }

        public static List<PaymentType> GetAllPaymentTypes()
        {
            List<PaymentType> pt = PaymentRepository.GetAllPaymentTypes();
            return pt;
        }
    }
}