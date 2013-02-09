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
    public partial class MainForm : Form
    {
        //public List<Bitmap> GraphLayer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void TypeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            form.ShowDialog();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductInStockForm();
            form.ShowDialog();
        }

        private void OrganizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new OrganizationForm();
            form.ShowDialog();
        }

        private void ActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ActionForm();
            form.ShowDialog();
        }

        private void TypeProduct_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            form.ShowDialog();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            var form = new ProductInStockForm();
            form.ShowDialog();
        }

        private void Organization_Click(object sender, EventArgs e)
        {
            var form = new OrganizationForm();
            form.ShowDialog();
        }

        private void Action_Click(object sender, EventArgs e)
        {
            var form = new ActionForm();
            form.ShowDialog();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            var form = new StockForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new PeriodReport();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TopProductReport frm = new TopProductReport();
            frm.ShowDialog();
        }
    }
}
