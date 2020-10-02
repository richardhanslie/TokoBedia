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
    public partial class InsertPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            string type = Type.Text;

            Response respond = PaymentController.InsertPaymentType(type);

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