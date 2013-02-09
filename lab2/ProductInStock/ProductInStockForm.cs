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
    public partial class ProductInStockForm : Form
    {
        public ProductInStockForm()
        {
            InitializeComponent();

            dgvProductInStock.AutoGenerateColumns = false;

            FillCMB();
        }

        private void FillCMB()
        {
            cmbProducts.DataSource = ProductManager.ProductsList;
            cmbProducts.DisplayMember = "name";
            cmbProducts.ValueMember = "id";

            cmbStock.DataSource = StockManager.StockList;
            cmbStock.DisplayMember = "name";
            cmbStock.ValueMember = "id";

            cmbOrganisation.DataSource = OrganizationManager.OrganizationList;
            cmbOrganisation.ValueMember = "id";
            cmbOrganisation.DisplayMember = "Name";

        }

        private void ProductInStockForm_Load(object sender, EventArgs e)
        {
            cmbOperation.SelectedIndex = 0;
            dgvProductInStock.DataSource = ProductInStockManager.ProductInStockList;
        }

        private void btnOperationSubmit_Click(object sender, EventArgs e)
        {
            if (nudCount.Value > 0)
            {
                Guid prid = (Guid)cmbProducts.SelectedValue;
                Guid stid = (Guid)cmbStock.SelectedValue;
                Guid orgid = (Guid)cmbOrganisation.SelectedValue;
                if (cmbOperation.SelectedIndex == 0)
                {
                    ProductInStockManager.AddProductToStock(stid, prid, orgid, (int)nudCount.Value);
                }
                else
                {
                    ProductInStockManager.RemoveProductToStock(stid, prid, orgid, (int)nudCount.Value);
                }
                dgvProductInStock.DataSource = ProductInStockManager.ProductInStockList;
            }
        }

        private void dgvProductInStock_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex.Equals(dgvProductInStock.Columns["clmCount"].Index))
            {
                Guid id = ((ProductInStock)dgvProductInStock.Rows[e.RowIndex].DataBoundItem).ID;
                Guid orgid = (Guid)cmbOrganisation.SelectedValue;
                int newCount = (int)dgvProductInStock["clmCount", e.RowIndex].Value;
                ProductInStockManager.UpdateProductInStock(id, orgid, newCount);
            }
        }

        private void dgvProductInStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex.Equals(dgvProductInStock.Columns["clmProduct"].Index))
                {
                    e.Value = ProductManager.GetById((Guid)e.Value).Name;
                }
                else if (e.ColumnIndex.Equals(dgvProductInStock.Columns["clmStock"].Index))
                {
                    e.Value = StockManager.GetById((Guid)e.Value).Name;
                }

            }
        }
    }
}
