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
    public partial class ViewCompany : MetroFramework.Forms.MetroForm
    {
        public ViewCompany()
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

        private void label13_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
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
            View view = new View();
            this.Hide();
            view.Closed += (s, args) => this.Close();
            view.Show();
        }

        private void ViewCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.companyDataSet.Company);
            // TODO: This line of code loads data into the 'companyDataSource.Company' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet3.Company' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet2.Company' table. You can move, or remove it, as needed.


        }
        void showAllByCompany()
        {
            Passenger passenger = new Passenger();
            List<Passenger> passengerlist;

            PassengerServices passengerServices = new PassengerServices();

            String companyname = companyGridView.CurrentRow.Cells[0].Value.ToString();
            passenger.Company_Name = companyname;

            passengerlist = passengerServices.GetListByCompany(passenger);

            passengerGridView.DataSource = passengerlist;

            passengerGridView.Columns[1].Width = 200;
            passengerGridView.Columns[1].HeaderText = "Name";

            passengerGridView.Columns[2].Width = 200;
            passengerGridView.Columns[2].HeaderText = "Passport No";
            passengerGridView.Columns[0].Visible = false;
            passengerGridView.Columns[3].Visible = false;
            passengerGridView.Columns[4].Visible = false;
            passengerGridView.Columns[5].Visible = false;
            passengerGridView.Columns[6].Visible = false;
            passengerGridView.Columns[7].Visible = false;
            passengerGridView.Columns[8].Visible = false;
            passengerGridView.Columns[9].Visible = false;
            passengerGridView.Columns[10].Visible = false;
            passengerGridView.Columns[11].Visible = false;




        }

        private void companyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showAllByCompany();
        }
    }
}
