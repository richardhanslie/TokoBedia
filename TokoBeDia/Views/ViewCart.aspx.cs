using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controllers;
using TokoBeDia.Helpers;
using TokoBeDia.Model.AdditionalModel;

namespace TokoBeDia.Views
{
    public partial class ViewCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridList();

            string id = Session["id"].ToString();
            GrandTodal.Text = CartController.GetGrandTotal(int.Parse(id)).ToString();
        }

        protected void BindGridList()
        {
            string id = Session["id"].ToString();
            GridView1.DataSource = CartController.GetAllCartProducts(int.Parse(id));
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string userId = Session["id"].ToString();
            int rowIndex = e.RowIndex;
            string productId = GridView1.Rows[rowIndex].Cells[2].Text;
            CartController.DeleteCart(int.Parse(userId), int.Parse(productId));
            Response.Redirect("ViewCart.aspx");
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string productId = GridView1.Rows[rowIndex].Cells[2].Text;
            Response.Redirect("UpdateCart.aspx?id=" + productId);
        }

        protected void Checkout_Click(object sender, EventArgs e)
        {
            string id = Session["id"].ToString();
            Response respond = CartController.CheckoutValidation(int.Parse(id));

            if(respond.successStatus == true)
            {
                Response.Redirect("Checkout.aspx");
            }
            else
            {
                alert.Text = respond.message;
            }
        }
    }
}