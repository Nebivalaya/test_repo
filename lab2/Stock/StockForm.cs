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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
            dgvStocks.AutoGenerateColumns = false;
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNewStock.Text) && StockManager.StockList.Where(wh => wh.Name.Equals(tbNewStock.Text)).Count() <= 0)
            {
                StockManager.AddStock(tbNewStock.Text);
                dgvStocks.DataSource = StockManager.StockList;
                tbNewStock.Text = string.Empty;
            }
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            dgvStocks.DataSource = StockManager.StockList;
        }

        private void dgvStocks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Guid id = (Guid)dgvStocks["clmId", e.RowIndex].Value;
                string newName = (string)dgvStocks["clmName", e.RowIndex].Value;
                StockManager.UpdateStock(id, newName);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
