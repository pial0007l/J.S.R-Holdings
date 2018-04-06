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
using J.S.R_Holdings.Services;

namespace J.S.R_Holdings
{
    public partial class ViewPassenger : MetroFramework.Forms.MetroForm
    {
      
        public ViewPassenger()
        {
            
            InitializeComponent();
            
        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PassengerDataSet.Passenger' table. You can move, or remove it, as needed.
            this.passengerTableAdapter.Fill(this._PassengerDataSet.Passenger);
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet1.Agent' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet.Passenger' table. You can move, or remove it, as needed.

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


        
        

        private void passengergridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Passenger passenger = new Passenger();
            PassengerServices passengerServices = new PassengerServices();

            String passportNo = passengergridview.CurrentRow.Cells[2].Value.ToString();
            passenger.Passport_No = passportNo;


            PassengerDetails passengerDetails = new PassengerDetails(passengerServices.GetByPassport(passenger));
            this.Hide();
            passengerDetails.Closed += (s, args) => this.Close();
            passengerDetails.Show();
        }

        
    }
}
