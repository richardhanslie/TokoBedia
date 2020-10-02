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
    public partial class ViewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridList();
        }

        protected void BindGridList()
        {
            string id = Session["id"].ToString();
            GridView1.DataSource = UserController.GetAllUser(int.Parse(id));
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Allow")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                UserController.AllowUser(index);
                Response.Redirect("ViewUser.aspx");
            }

            if (e.CommandName == "Block")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                UserController.BlockUser(index);
                Response.Redirect("ViewUser.aspx");
            }

            if (e.CommandName == "Administrator")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                UserController.ChangeToAdminitrator(index);
                Response.Redirect("ViewUser.aspx");
            }

            if (e.CommandName == "Member")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                UserController.ChangeToMember(index);
                Response.Redirect("ViewUser.aspx");
            }
        }
    }
}