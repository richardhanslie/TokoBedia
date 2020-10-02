using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controllers;

namespace TokoBeDia.Views
{
    public partial class ViewTransactionHistoryMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridList();
        }

        protected void BindGridList()
        {
            string id = Session["id"].ToString();
            GridView1.DataSource = TransactionController.GetHeaderTransactionByUserId(int.Parse(id));
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("ViewDetailTransaction.aspx?id=" + index);
        }
    }
}