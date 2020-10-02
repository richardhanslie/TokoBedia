using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;
using TokoBeDia.Model.AdditionalModel;

namespace TokoBeDia.Factories
{
    public class CartFactory
    {
        public static Cart GetCart(int userId, int productId, int qty)
        {
            Cart c = new Cart
            {
                UserId = userId,
                ProductId = productId,
                Quantity = qty
            };

            return c;
        }
    }
}