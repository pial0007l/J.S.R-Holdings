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
    public partial class PassengerDetails : MetroFramework.Forms.MetroForm
    {
        
        public PassengerDetails(Passenger passenger)
        {
            InitializeComponent();
            this.passportNoLebel.Text = passenger.Passport_No;
            this.nameLabel.Text = passenger.Name;
            this.dateOfBirthLabel.Text = passenger.Date_of_birth;
            this.addressLabel.Text = passenger.Address;
            this.fathersNameLabel.Text = passenger.Fathers_name;
            this.mobileNoLabel.Text = passenger.Mobile_No;
            this.expireDateLabel.Text = passenger.Expire_date;
            this.entryDateLabel.Text = passenger.Entry_Date;
            this.agentNameLabel.Text = passenger.Agent_name;
            this.companyNameLabel.Text = passenger.Company_Name;
            this.serialNoLAbel.Text = passenger.Serial_no;
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Blue;
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Black;
        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Blue;
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Black;
        }

        private void label24_Click(object sender, EventArgs e)
        {
            ViewPassenger viewpassenger = new ViewPassenger();
            this.Hide();
            viewpassenger.Closed += (s, args) => this.Close();
            viewpassenger.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
        }
    }
}
