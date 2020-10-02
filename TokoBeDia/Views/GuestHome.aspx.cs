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
    public partial class GuestHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridList();
        }

        protected void BindGridList()
        {
            GridView1.DataSource = ProductController.GetFiveProduct();
            GridView1.DataBind();
        }
        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void ViewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductForGuest.aspx");
        }
    }
}