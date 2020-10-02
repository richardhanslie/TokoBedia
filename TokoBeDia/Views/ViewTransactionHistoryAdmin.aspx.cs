using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controllers;

namespace TokoBeDia.Views
{
    public partial class ViewTransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridList();
        }

        protected void BindGridList()
        {
            GridView1.DataSource = TransactionController.GetAllHeaderTransaction();
            GridView1.DataBind();
        }

        protected void TransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionReport.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("ViewDetailTransaction.aspx?id=" + index);
        }
    }
}