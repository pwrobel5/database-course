using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Entity
{
    public partial class ChooseCustomer : Form
    {
        private ProdContext prodContext;
        public ChooseCustomer()
        {
            InitializeComponent();
        }

        private void ChooseCustomer_Load(object sender, EventArgs e)
        {
            prodContext = new ProdContext();
        }

        private void ChooseCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            prodContext.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String companyName = this.companyNameTextBox.Text;
            bool companyExists = prodContext.Customers.Any(c => c.CompanyName == companyName);

            if(!companyExists)
            {
                MessageBox.Show("Non-valid company name", "Logging error", MessageBoxButtons.OK);
            }
            else
            {
                CategoryForm categoryForm = new CategoryForm(companyName);
                categoryForm.ShowDialog();
                this.Close();
            }
        }
    }
}
