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
    public partial class CompanyUpdate :MetroFramework.Forms.MetroForm
    {
        public string id;
        public CompanyUpdate()
        {
            InitializeComponent();
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

        private void label12_Click(object sender, EventArgs e)
        {
            UpdateHomePage update = new UpdateHomePage();
            this.Hide();
            update.Closed += (s, args) => this.Close();
            update.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
        }

        private void CompanyUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet2.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.companyDataSet2.Company);

        }

        private void deleteCompanygridview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.companynameUpdateTextBox.Text = UpdateCompanygridview.CurrentRow.Cells[0].Value.ToString();
            this.salaryUpdateTextBox.Text = UpdateCompanygridview.CurrentRow.Cells[1].Value.ToString();
            this.workTypeUpdateTextBox.Text=UpdateCompanygridview.CurrentRow.Cells[2].Value.ToString();
            this.vacancyUpdateTextBox.Text = UpdateCompanygridview.CurrentRow.Cells[3].Value.ToString();
            id = UpdateCompanygridview.CurrentRow.Cells[4].Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Company company = new Company();

            company.Name = companynameUpdateTextBox.Text;
            company.Salary = salaryUpdateTextBox.Text;
            company.Work_type = workTypeUpdateTextBox.Text;
            company.Vacancy = vacancyUpdateTextBox.Text;
            company.Id = Convert.ToInt32(id);

            CompanyServices companyservices = new CompanyServices();

            if (companyservices.Update(company) == 1)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }

            CompanyUpdate companyupdate = new CompanyUpdate();
            this.Hide();
            companyupdate.Closed += (s, args) => this.Close();
            companyupdate.Show();
        }
    }
}
