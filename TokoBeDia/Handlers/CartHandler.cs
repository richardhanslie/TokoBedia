using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Helpers;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;
using TokoBeDia.Repositories;

namespace TokoBeDia.Handlers
{
    public class CartHandler
    {
        public static Cart GetCart(int userId, int productId)
        {
            Cart c = CartRepository.GetCart(userId, productId);
            return c;
        }

        public static List<ViewCartModel> GetAllCartProducts(int userId)
        {
            List<Cart> c = CartRepository.GetAllCarts(userId);

            List<ViewCartModel> vc = new List<ViewCartModel>();
            foreach(var item in c)
            {
                ViewCartModel viewCart = CartRepository.GetAllCartProducts(item);
                vc.Add(viewCart);
            }
            return vc;
        }

        public static int GetGrandTotal(int userId)
        {
            int total = 0;
            List<Cart> c = CartRepository.GetAllCarts(userId);
            foreach (var item in c)
            {
                ViewCartModel viewCart = CartRepository.GetAllCartProducts(item);
                total = total + viewCart.Subtotal;
            }
            return total;
        }

        public static Cart DeleteCart(int userId, int productId)
        {
            Cart c = CartRepository.DeleteCart(userId, productId);
            return c;
        }

        public static Cart UpdateCart(int userId, int productId, int qty)
        {
            Cart c = new Cart();
            if (qty == 0)
            {
                c = CartRepository.DeleteCart(userId, productId);
            }
            else
            {
                c = CartRepository.UpdateCart(userId, productId, qty);
            }
            return c;
        }
    }
}