using J.S.R_Holdings.Entity;
using J.S.R_Holdings.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J.S.R_Holdings
{
    public partial class DeleteCompany : MetroFramework.Forms.MetroForm
    {
        public DeleteCompany()
        {
            InitializeComponent();
        }

        private void DeleteCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.companyDataSet.Company);
            // TODO: This line of code loads data into the 'companyDataSource.Company' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet3.Company' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet2.Company' table. You can move, or remove it, as needed.

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            this.Hide();
            delete.Closed += (s, args) => this.Close();
            delete.Show();
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Blue;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Black;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Blue;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Black;
        }

        private void refresh_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Blue;
        }

        private void refresh_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Black;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            DeleteCompany deletecompany = new DeleteCompany();
            this.Hide();
            deletecompany.Closed += (s, args) => this.Close();
            deletecompany.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
        }

        private void deleteCompanygridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Company company = new Company();
            CompanyServices companyservices = new CompanyServices();

            String companyName = deleteCompanygridview.CurrentRow.Cells[0].Value.ToString();
            company.Name = companyName;

            if (companyservices.Remove(company) == 1)
            {

                MessageBox.Show("Successfully Deleted");
            }
        }
    }
}
