using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factories;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;

namespace TokoBeDia.Repositories
{
    public class CartRepository
    {
        public static TokoBeDiaEntities db = new TokoBeDiaEntities();

        public static Cart InsertCart(int userId, int productId, int qty)
        {
            Cart c = CartFactory.GetCart(userId, productId, qty);
            db.Carts.Add(c);
            db.SaveChanges();

            return c;
        }

        public static Cart GetCart(int userId, int productId)
        {
            Cart c = (from a in db.Carts where a.UserId == userId && a.ProductId == productId select a).FirstOrDefault();
            return c;
        }

        public static Cart UpdateCart(int userId, int productId, int qty)
        {
            Cart c = GetCart(userId, productId);
            c.Quantity = qty;
            db.SaveChanges();

            return c;
        }

        public static List<Cart> GetAllCarts(int userId)
        {
            List<Cart> c = (from a in db.Carts where a.UserId == userId select a).ToList();
            return c;
        }

        public static ViewCartModel GetAllCartProducts(Cart item)
        {
            ViewCartModel vc = (from a in db.Products where a.Id == item.ProductId select 
                                new ViewCartModel() {
                                    ProductID = a.Id,
                                    ProductName = a.Name,
                                    ProductPrice = a.Price,
                                    Quantity = item.Quantity,
                                    Subtotal = item.Quantity * a.Price
                                }).FirstOrDefault();
            return vc;
        }

        public static Cart DeleteCart(int userId, int productId)
        {
            Cart c = GetCart(userId, productId);
            db.Carts.Remove(c);
            db.SaveChanges();

            return c;
        }

        public static void DeleteAllCarts(int userId)
        {
            List<Cart> c = (from a in db.Carts where a.UserId == userId select a).ToList();
            
            foreach(var item in c)
            {
                db.Carts.Remove(item);
            }
            db.SaveChanges();
        }
    }
}