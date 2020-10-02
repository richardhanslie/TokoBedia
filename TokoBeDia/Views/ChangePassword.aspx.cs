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
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string id = Session["id"].ToString();

            string oldPassword = old.Text;
            string newPassword = newPass.Text;
            string confirmPassword = confirm.Text;

            Response respond = UserController.ChangePassword(int.Parse(id), newPassword, oldPassword, confirmPassword);

            if(respond.successStatus == true)
            {
                Response.Redirect("Profile.aspx");
            }
            else
            {
                alert.Text = respond.message;
            }

        }
    }
}