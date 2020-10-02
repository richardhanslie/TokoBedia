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
    public partial class UpdateProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            ProductType pt = ProductTypeController.GetProductTypeById(id);
            oldType.Text = pt.Name;
            oldDesc.Text = pt.Description;
        }

        protected void update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            string name = nameTxt.Text;
            string desc = descTxt.Text;

            Response respond = ProductTypeController.UpdateProductType(id, name, desc);

            if(respond.successStatus)
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