using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Helpers;
using TokoBeDia.Model;
using TokoBeDia.Repositories;

namespace TokoBeDia.Handlers
{
    public class AddToCartHandler
    {
        public static Response DoAddToCart(int userId, int productId, int qty, int stock)
        {
            Cart existCart = CartRepository.GetCart(userId, productId);

            if (existCart == null)
            {
                CartRepository.InsertCart(userId, productId, qty);
                return new Response(true);
            }
            else
            {
                if (existCart.Quantity + qty > stock)
                {
                    return new Response(false, "the inputted quantity and the reserved quantity in other carts combined altogether must not exceed the selected product’s current stock");
                }
                else
                {
                    CartRepository.UpdateCart(userId, productId, qty + existCart.Quantity);
                    return new Response(true);
                }
            }
        }
    }
}