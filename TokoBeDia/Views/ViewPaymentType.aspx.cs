using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controllers;
using TokoBeDia.Helpers;

namespace TokoBeDia.Views
{
    public partial class ViewPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                BindGridList();
        }

        protected void BindGridList()
        {
            GridView1.DataSource = PaymentController.GetAllPaymentTypes();
            GridView1.DataBind();
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPaymentType.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("UpdatePaymentType.aspx?id=" + index);
            }

            if (e.CommandName == "Delete_Payment")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Response respond = PaymentController.DeletePaymentType(index);
                if (respond.successStatus == false)
                    alert.Text = respond.message;
                else
                    Response.Redirect("ViewPaymentType.aspx");
            }
        }
    }
}