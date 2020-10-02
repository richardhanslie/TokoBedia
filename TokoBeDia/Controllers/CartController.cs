using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handlers;
using TokoBeDia.Helpers;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;

namespace TokoBeDia.Controllers
{
    public class CartController
    {
        public static List<ViewCartModel> GetAllCartProducts(int userId)
        {
            List<ViewCartModel> vc = CartHandler.GetAllCartProducts(userId);
            return vc;
        }

        public static void DeleteCart(int userId, int productId)
        {
            CartHandler.DeleteCart(userId, productId);
        }

        public static Response UpdateCart(int userId, int productId, int qty)
        {
            int n = 0;
            bool isNumeric = int.TryParse(qty.ToString(), out n);

            Product p = ProductHandler.GetProduct(productId);

            if (isNumeric == false)
                return new Response(false, "must be numeric");
            else if (qty > p.Stock)
                return new Response(false, "must be less than or equals to current stock");
            else if (qty < 0)
                return new Response(false, "input field cannot be inputted below 0");
            else
            {
                CartHandler.UpdateCart(userId, productId, qty);
                return new Response(true);
            }
        }

        public static int GetGrandTotal(int userId)
        {
            int total = CartHandler.GetGrandTotal(userId);
            return total;
        }

        public static Response CheckoutValidation(int userId)
        {
            List<ViewCartModel> vc = GetAllCartProducts(userId);
            if (vc == null)
            {
                return new Response(false, "cart cannot be empty");
            }
            else
            {
                return new Response(true);
            }
        }
    }
}