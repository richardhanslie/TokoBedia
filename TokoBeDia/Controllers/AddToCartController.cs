using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Handlers;
using TokoBeDia.Helpers;
using TokoBeDia.Model;
using TokoBeDia.Repositories;

namespace TokoBeDia.Controllers
{
    public class AddToCartController
    {
        public static Response DoAddToCart(int userId, int productId, int qty)
        {
            int n = 0;
            bool isNumeric = int.TryParse(qty.ToString(), out n);

            Product p = ProductHandler.GetProduct(productId);

            if (isNumeric == false)
                return new Response(false, "must be numeric");
            else if (qty <= 0)
                return new Response(false, "must be more than 0");
            else if (qty > p.Stock)
                return new Response(false, "must be less than or equals to current stock");
            else
            {
                Response respond = AddToCartHandler.DoAddToCart(userId, productId, qty, p.Stock);
                return respond;
            }
        }
    }
}