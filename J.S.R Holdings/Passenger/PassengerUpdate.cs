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
    public partial class PassengerUpdate : MetroFramework.Forms.MetroForm
    {
        public PassengerUpdate()
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

        private void PassengerUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PassengerDataSet.Passenger' table. You can move, or remove it, as needed.
            this.passengerTableAdapter.Fill(this._PassengerDataSet.Passenger);
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet2.Passenger' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet.Passenger' table. You can move, or remove it, as needed.

        }

        private void passengergridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Passenger passenger = new Passenger();
            PassengerServices passengerServices = new PassengerServices();

            String passportNo = updatepassengergridview.CurrentRow.Cells[2].Value.ToString();
            passenger.Passport_No = passportNo;


            UpdatePassengerDetails updatepasengerdetails = new UpdatePassengerDetails(passengerServices.GetByPassport(passenger));
            this.Hide();
            updatepasengerdetails.Closed += (s, args) => this.Close();
            updatepasengerdetails.Show();
        }

        void showAllByPassport()
        {
            Passenger passenger = new Passenger();
            List<Passenger> passengerlist;

            PassengerServices passengerServices = new PassengerServices();

            String passportno = searchTextbox.Text;
            passenger.Passport_No = passportno;

            passengerlist = passengerServices.GetListByPassport(passenger);

            passengerGridView.DataSource = passengerlist;

            passengerGridView.Columns[2].Width = 200;
            passengerGridView.Columns[2].HeaderText = "Name";

            passengerGridView.Columns[1].Visible = false;
            //passengerGridView.Columns[2].HeaderText = "Passport No";
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            showAllByPassport();
        }

        private void passengerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Passenger passenger = new Passenger();
            PassengerServices passengerServices = new PassengerServices();

            String passportno = searchTextbox.Text;
            passenger.Passport_No = passportno;


            UpdatePassengerDetails updatepasengerdetails = new UpdatePassengerDetails(passengerServices.GetByPassport(passenger));
            this.Hide();
            updatepasengerdetails.Closed += (s, args) => this.Close();
            updatepasengerdetails.Show();
        }
    }
}
