using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controllers;
using TokoBeDia.Model;
using TokoBeDia.Repositories;

namespace TokoBeDia.Website
{
    public partial class MemberHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("GuestHome.aspx");
            }

            string id = Session["id"].ToString();
            User u = UserController.GetId(int.Parse(id));
            name.Text = u.Name;

            if (!IsPostBack)
                BindGridList();
        }

        protected void BindGridList()
        {
            GridView1.DataSource = ProductController.GetFiveProduct();
            GridView1.DataBind();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Response.Cookies["email"].Expires = DateTime.Now.AddHours(-1);
            Response.Cookies["password"].Expires = DateTime.Now.AddHours(-1);
            Response.Cookies["name"].Expires = DateTime.Now.AddHours(-1);
            Response.Redirect("GuestHome.aspx");
        }

        protected void ViewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductMember.aspx");
        }

        protected void ViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void ViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCart.aspx");
        }

        protected void ViewTransactionHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionHistoryMember.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("AddToCart.aspx?id=" + index);
            }
        }
    }
}