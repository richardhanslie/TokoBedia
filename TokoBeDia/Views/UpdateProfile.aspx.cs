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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Session["id"].ToString();
            User u = UserController.GetId(int.Parse(id));

            if (Page.IsPostBack == false)
            {
                emailTxt.Text = u.Email;
                nameTxt.Text = u.Name;
                if (u.Gender == "Male")
                {
                    Male.Checked = true;
                }
                else if (u.Gender == "Female")
                {
                    Female.Checked = true;
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string id = Session["id"].ToString();
            User u = UserController.GetId(int.Parse(id));

            string name = nameTxt.Text;
            string email = emailTxt.Text;
            string gender = "";

            if (Male.Checked)
                gender = "Male";
            else
                gender = "Female";

            Response respond = UserController.UpdateProfile(u.Id, name, email, gender);

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