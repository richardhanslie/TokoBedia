using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Controllers;
using TokoBeDia.Model;
using TokoBeDia.Repositories;

namespace TokoBeDia.Website
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                Response.Redirect("MemberHome.aspx");
            }

            if (Page.IsPostBack == false)
            {
                if (Request.Cookies["email"] != null && Request.Cookies["password"] != null && Request.Cookies["name"] != null)
                {
                    emailTxt.Text = Request.Cookies["email"].Value;
                    passwordTxt.Text = Request.Cookies["password"].Value;
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;

            User u = LoginController.DoLogin(email, password);

            if(u!= null)
            {
                Session["id"] = u.Id;
                if (checkRemember.Checked && u.Status=="Allow")
                {
                    Response.Cookies["email"].Value = u.Email;
                    Response.Cookies["email"].Expires = DateTime.Now.AddDays(3);

                    Response.Cookies["password"].Value = u.Password;
                    Response.Cookies["password"].Expires = DateTime.Now.AddDays(3);

                    Response.Cookies["name"].Value = u.Name;
                    Response.Cookies["name"].Expires = DateTime.Now.AddDays(3);
                }
                if(u.RoleId == 1)
                {
                    Response.Redirect("AdministratorHome.aspx");
                }
                else if(u.Status == "Blocked")
                {
                    Label1.Text = "You are Blocked by the administrator";
                }
                else if(u.RoleId == 2 && u.Status == "Allow")
                {
                    Response.Redirect("MemberHome.aspx");
                }
            }
        }
    }
}