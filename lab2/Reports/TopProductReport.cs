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
    public partial class TopProductReport : Form
    {
        public TopProductReport()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var topProduct = OperationManager.OperationList
                .Where(wh => !wh.Income && wh.OperationDate.Month == DateTime.Now.Month)
                .GroupBy(g => g.ProductId)
                .Select(se => new
                {
                    productid = se.Key,
                    name = ProductManager.GetById((Guid)se.Key).Name,
                    Cnt = se.Sum(su => su.Count)
                })
                .OrderByDescending(o => o.Cnt).FirstOrDefault();

            var org = OperationManager.OperationList
            .Where(wh => !wh.Income && wh.OperationDate.Month == DateTime.Now.Month && wh.ProductId == topProduct.productid)
            .GroupBy(g => g.OrganizationId)
            .Select(se => new
            {
                ID = se.Key,
                Count = se.Sum(su => su.Count)
            }
            )
            .OrderByDescending(o => o.Count)
            .Join(OrganizationManager.OrganizationList, n => n.ID, m => m.ID, (n, m) => new { OrganizaionName = m.Name, OutCome = n.Count }).ToList();

            dgvReport.DataSource = org;
        }
    }
}
