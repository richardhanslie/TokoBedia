﻿using System;
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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridList();
        }

        protected void BindGridList()
        {
            GridView1.DataSource = ProductTypeController.GetAllProductTypes();
            GridView1.DataBind();
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("UpdateProductType.aspx?id=" + index);
            }

            if (e.CommandName == "Delete_Type")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Response respond = ProductTypeController.DeleteProductType(index);
                if (respond.successStatus == false)
                    alert.Text = respond.message;
                else
                    Response.Redirect("ViewProductType.aspx");
            }
        }
    }
}