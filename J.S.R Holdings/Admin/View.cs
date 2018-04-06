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
    public partial class View : MetroFramework.Forms.MetroForm
    {
        public View()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
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

        private void viewPassenger_Click(object sender, EventArgs e)
        {
            ViewPassenger viewpassenger = new ViewPassenger();
            this.Hide();
            viewpassenger.Closed += (s, args) => this.Close();
            viewpassenger.Show();
            
        }

        private void viewAgent_Click(object sender, EventArgs e)
        {
            AgentDetailsView agentView = new AgentDetailsView();
            this.Hide();
            agentView.Closed += (s, args) => this.Close();
            agentView.Show();
        }

        private void viewCompany_Click(object sender, EventArgs e)
        {
            ViewCompany viewCompany = new ViewCompany();
            this.Hide();
            viewCompany.Closed += (s, args) => this.Close();
            viewCompany.Show();
        }
    }
}
