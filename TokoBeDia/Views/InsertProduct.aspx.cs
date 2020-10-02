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
    public partial class InsertProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insert_Click(object sender, EventArgs e)
        {
            // note : karena ga disuruh masukin product typenya apa, jadi saya anggap type di insert berdasarkan id product type
            string name = nameTxt.Text;
            int price = int.Parse(priceTxt.Text);
            int stock = int.Parse(stockTxt.Text);
            int productType = int.Parse(typeTxt.Text);

            Response respond = ProductController.InsertProduct(productType, name, price, stock);
            
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