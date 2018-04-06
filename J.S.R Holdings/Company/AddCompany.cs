using J.S.R_Holdings.Services;
using J.S.R_Holdings.Entity;
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
    public partial class AddCompany : MetroFramework.Forms.MetroForm
    {
        public static int id_c;
        public AddCompany()
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

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Blue;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Black;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            this.Hide();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            companynameTextBox.Text = "";
            salaryTextBox.Text = "";
            vacancyTextBox.Text = "";
            workTypeTextBox.Text = "";
           
            companynameTextBox.Text = "";
        }

        private void Add()
        {
            id_c = id_c + 1;
            Company company = new Company();
            if (companynameTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Enter Name");
            }
            else
            {
                
                company.Id = id_c;
                company.Name = companynameTextBox.Text;
                company.Salary = salaryTextBox.Text;
                company.Work_type = workTypeTextBox.Text;
                company.Vacancy = vacancyTextBox.Text;

                CompanyServices companyservices = new CompanyServices();
                if (companyservices.Add(company) == 1)
                {
                    MessageBox.Show("Insert Successfull");
                }
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Add();
        }
    }
}
