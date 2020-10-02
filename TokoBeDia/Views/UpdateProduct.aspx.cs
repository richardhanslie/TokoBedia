using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controllers;
using TokoBeDia.Helpers;
using TokoBeDia.Model;
using TokoBeDia.Repositories;

namespace TokoBeDia.Website
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Product p = ProductController.GetProduct(id);
            oldName.Text = p.Name;
            oldStock.Text = p.Stock.ToString();
            oldPrice.Text = p.Price.ToString();
            oldType.Text = p.ProductType.Name;
        }

        protected void update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            string name = nameTxt.Text;
            int price = int.Parse(priceTxt.Text);
            int stock = int.Parse(stockTxt.Text);
            int productType = int.Parse(typeTxt.Text);

            Response respond = ProductController.UpdateProduct(id, name, price, stock, productType);

            if(respond.successStatus == true)
            {
                Response.Redirect("AdministratorHome.aspx");
            }
            else
            {
                alert.Text = respond.message;
            }
        }
    }
}