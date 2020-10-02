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
    public partial class UpdatePaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            PaymentType pt = PaymentController.GetPaymentTypeById(id);
            oldType.Text = pt.Type;
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            string type = Type.Text;
            int id = int.Parse(Request.QueryString["id"]);

            Response respond = PaymentController.UpdatePaymentType(id, type);

            if(respond.successStatus == true)
            {
                Response.Redirect("ViewPaymentType.aspx");
            }
            else
            {
                alert.Text = respond.message;
            }
        }
    }
}