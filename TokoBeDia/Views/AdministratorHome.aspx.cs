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
    public partial class AdministratorHome : System.Web.UI.Page
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
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Response.Cookies["email"].Expires = DateTime.Now.AddHours(-1);
            Response.Cookies["password"].Expires = DateTime.Now.AddHours(-1);
            Response.Cookies["name"].Expires = DateTime.Now.AddHours(-1);
            Response.Redirect("GuestHome.aspx");
        }

        protected void ViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void ViewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProduct.aspx");
        }

        protected void InsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void InsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType.aspx");
        }

        protected void ViewProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductType.aspx");
        }

        protected void ViewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }

        protected void ViewPaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPaymentType.aspx");
        }

        protected void InsertPaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPaymentType.aspx");
        }

        protected void ViewTransactionHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionHistoryAdmin.aspx");
        }
    }
}