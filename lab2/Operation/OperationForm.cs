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
    public partial class ActionForm : Form
    {
        public ActionForm()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
        }

        private void ActionForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OperationManager.OperationList;
        }
    }
}
