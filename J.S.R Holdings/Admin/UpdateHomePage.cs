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
    public partial class UpdateHomePage : MetroFramework.Forms.MetroForm
    {
        public UpdateHomePage()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
        }

        private void updatePassengerbutton_Click(object sender, EventArgs e)
        {
            PassengerUpdate passengerupdate = new PassengerUpdate();
            this.Hide();
            passengerupdate.Closed += (s, args) => this.Close();
            passengerupdate.Show();
        }

        private void AgentUpdateButton_Click(object sender, EventArgs e)
        {
            Agent_Update agentupdate = new Agent_Update();
            this.Hide();
            agentupdate.Closed += (s, args) => this.Close();
            agentupdate.Show();
        }

        private void CompanyUpdatebutton_Click(object sender, EventArgs e)
        {
            CompanyUpdate companyupdate = new CompanyUpdate();
            this.Hide();
            companyupdate.Closed += (s, args) => this.Close();
            companyupdate.Show();
        }
    }
}
