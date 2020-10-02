using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factories;
using TokoBeDia.Model;

namespace TokoBeDia.Repositories
{
    public class PaymentRepository
    {
        public static TokoBeDiaEntities db = new TokoBeDiaEntities();

        public static PaymentType InsertPaymentType(string type)
        {
            PaymentType pt = PaymentFactory.GetPaymentType(type);
            db.PaymentTypes.Add(pt);
            db.SaveChanges();

            return pt;
        }

        public static PaymentType GetPaymentTypeById(int id)
        {
            PaymentType pt = (from a in db.PaymentTypes where a.Id == id select a).FirstOrDefault();
            return pt;
        }

        public static PaymentType GetPaymentTypeByName(string type)
        {
            PaymentType pt = (from a in db.PaymentTypes where a.Type == type select a).FirstOrDefault();
            return pt;
        }

        public static PaymentType UpdatePaymentType(int id, string type)
        {
            PaymentType pt = GetPaymentTypeById(id);
            pt.Type = type;
            db.SaveChanges();

            return pt;
        }

        public static PaymentType DeletePaymentType(int id)
        {
            try
            {
                PaymentType pt = GetPaymentTypeById(id);
                db.PaymentTypes.Remove(pt);
                db.SaveChanges();

                return pt;
            }
            catch
            {
                return null;
            }
            
        }

        public static List<PaymentType> GetAllPaymentTypes()
        {
            List<PaymentType> pt = (from a in db.PaymentTypes select a).ToList();
            return pt;
        }
    }
}