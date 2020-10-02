using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controllers;
using TokoBeDia.Helpers;
using TokoBeDia.Model;

namespace TokoBeDia.Views
{
    public partial class UpdateCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int productId = Int32.Parse(Request.QueryString["id"]);
            Product p = ProductController.GetProduct(productId);

            Name.Text = p.Name;
            Price.Text = p.Price.ToString();
            Stock.Text = p.Stock.ToString();
            ProductType.Text = p.ProductType.Name;
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            string userId = Session["id"].ToString();
            int productId = Int32.Parse(Request.QueryString["id"]);
            int qty = int.Parse(Quantity.Text);

            Response respond = CartController.UpdateCart(int.Parse(userId), productId, qty);

            if(respond.successStatus == true)
            {
                Response.Redirect("ViewCart.aspx");
            }
            else
            {
                alert.Text = respond.message;
            }
        }
    }
}