using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    public partial class PeriodReport : Form
    {
        public PeriodReport()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            var resultA = OperationManager.OperationList
                .Where(wh => wh.OperationDate.Date >= dtpPeriodAFrom.Value.Date && wh.OperationDate <= dtpPeriodATo.Value.Date.AddDays(1) && !wh.Income)
                .GroupBy(g => g.ProductId)
                .Select(se => new
                {
                    productid = se.Key,
                    Cnt = se.Sum(su => su.Count)
                });



            var resultB = OperationManager.OperationList
                .Where(wh => wh.OperationDate >= dtpPeriodBFrom.Value.Date && wh.OperationDate <= dtpPeriodBTo.Value.Date.AddDays(1) && !wh.Income)
                .GroupBy(g => g.ProductId)
                .Select(se => new
                {
                    productid = se.Key,
                    Cnt = se.Sum(su => su.Count)
                });

            var result = resultA.Join(resultB, ra => ra.productid, rb => rb.productid, (ra, rb) => new { ProductId = ra.productid, CountA = ra.Cnt, CountB = rb.Cnt})
                .Where(wh => wh.CountA >= wh.CountB)
                .Select(se => new
                {
                    ProductName = ProductManager.GetById((Guid)se.ProductId).Name,
                    Count = se.CountA
                }
                ).ToList();

            dgvReport.DataSource = result;
        }
    }
}
