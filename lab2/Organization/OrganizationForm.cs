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
    public partial class OrganizationForm : Form
    {
        public OrganizationForm()
        {
            InitializeComponent();
            dgvOrganization.AutoGenerateColumns = false;
        }

        private void OrganizationForm_Load(object sender, EventArgs e)
        {
            dgvOrganization.DataSource = OrganizationManager.OrganizationList;
        }

        private void btnAddOrganization_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNewOrganization.Text) && OrganizationManager.OrganizationList.Where(wh => wh.Name.Equals(tbNewOrganization.Text)).Count() <= 0)
            {
                OrganizationManager.AddOrganization(tbNewOrganization.Text);
                dgvOrganization.DataSource = OrganizationManager.OrganizationList;
                tbNewOrganization.Text = string.Empty;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
