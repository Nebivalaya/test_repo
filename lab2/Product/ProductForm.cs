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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            dgvProductType.AutoGenerateColumns = false;
            dgvProductType.AllowUserToAddRows = true;

        }

        private void ProductTypeForm_Load(object sender, EventArgs e)
        {
            dgvProductType.DataSource = ProductManager.ProductsList;
        }

        private void dgvProductType_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Guid id = (Guid)dgvProductType["clmId", e.RowIndex].Value;
                string newName = (string)dgvProductType["clmName", e.RowIndex].Value;
                ProductManager.UpdateProduct(id, newName);
            }
        }

        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNewProductType.Text) && ProductManager.ProductsList.Where(wh => wh.Name.Equals(tbNewProductType.Text)).Count() <= 0)
            {
                ProductManager.AddProduct(tbNewProductType.Text);
                dgvProductType.DataSource = ProductManager.ProductsList;
                tbNewProductType.Text = string.Empty;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
