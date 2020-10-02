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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            int roleId = 2;
            string name = nameTxt.Text;
            string password = passwordTxt.Text;
            string confirmPassword = confirmPasswordTxt.Text;
            string gender = "";
            string status = "Allow";

            if (Male.Checked)
                gender = "Male";
            else if(Female.Checked)
                gender = "Female";

            Response respond = UserController.DoRegister(email, roleId, name, password, gender, status, confirmPassword);

            if (respond.successStatus == true)
                Response.Redirect("GuestHome.aspx");
            else
                alert.Text = respond.message; 
        }
    }
}