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
    public partial class DeletePassenger : MetroFramework.Forms.MetroForm

    {
        public DeletePassenger()
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
            Delete delete = new Delete();
            this.Hide();
            delete.Closed += (s, args) => this.Close();
            delete.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
        }

        private void DeletePassenger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'passengerDataSet2.Passenger' table. You can move, or remove it, as needed.
            this.passengerTableAdapter1.Fill(this.passengerDataSet2.Passenger);
            // TODO: This line of code loads data into the '_PassengerDataSet.Passenger' table. You can move, or remove it, as needed.
            this.passengerTableAdapter.Fill(this._PassengerDataSet.Passenger);
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet2.Passenger' table. You can move, or remove it, as needed.

        }



        private void deletepassengergridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Passenger passenger = new Passenger();
            PassengerServices passengerServices = new PassengerServices();

            String passportNo = deletepassengergridview.CurrentRow.Cells[2].Value.ToString();
            passenger.Passport_No = passportNo;

            if (passengerServices.Remove(passenger) == 1)
            {
                
                MessageBox.Show("Successfully Deleted");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            DeletePassenger deletepassenger = new DeletePassenger();
            this.Hide();
            deletepassenger.Closed += (s, args) => this.Close();
            deletepassenger.Show();
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
    }
}
