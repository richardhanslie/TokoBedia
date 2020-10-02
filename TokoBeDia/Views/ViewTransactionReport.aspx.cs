using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Model;

namespace TokoBeDia.Views
{
    public partial class ViewTransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportTransaction report = new ReportTransaction();
            CrystalReportViewer1.ReportSource = report;

            report.SetDataSource(GetData());
        }

        private ReportDataset GetData()
        {
            ReportDataset dataset = new ReportDataset();

            ReportDataset.HeaderTransactionDataTable headerTable = dataset.HeaderTransaction;
            ReportDataset.DetailTransactionDataTable detailTable = dataset.DetailTransaction;

            TokoBeDiaEntities db = new TokoBeDiaEntities();

            foreach(HeaderTransaction ht in db.HeaderTransactions)
            {
                DataRow headerRow = headerTable.NewRow();

                headerRow["Id"] = ht.Id;
                headerRow["Email"] = ht.User.Email;
                headerRow["Date"] = ht.Date;
                headerRow["PaymentType"] = ht.PaymentType.Type;

                headerTable.Rows.Add(headerRow);

                foreach(DetailTransaction dt in ht.DetailTransactions)
                {
                    DataRow detailRow = detailTable.NewRow();

                    detailRow["TransactionId"] = dt.TransactionId;
                    detailRow["ProductName"] = dt.Product.Name;
                    detailRow["ProductPrice"] = dt.Product.Price;
                    detailRow["Quantity"] = dt.Quantity;

                    detailTable.Rows.Add(detailRow);
                }
            }

            return dataset;
        }
    }
}