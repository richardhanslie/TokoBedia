using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controllers;
using TokoBeDia.Helpers;
using TokoBeDia.Model;
using TokoBeDia.Repositories;

namespace TokoBeDia.Website
{
    public partial class InsertProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insert_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string desc = descTxt.Text;

            Response respond = ProductTypeController.InsertProductType(name, desc);
            
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