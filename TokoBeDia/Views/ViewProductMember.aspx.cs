using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controllers;

namespace TokoBeDia.Views
{
    public partial class ViewProductMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridList();
        }

        protected void BindGridList()
        {
            GridView1.DataSource = ProductController.GetAllProducts();
            GridView1.DataBind();
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