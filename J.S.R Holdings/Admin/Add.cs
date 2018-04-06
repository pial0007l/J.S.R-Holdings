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
    public partial class Add : MetroFramework.Forms.MetroForm
    {
        public Add()
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

        private void label1_Enter(object sender, EventArgs e)
        {
            //((Control)sender)BackColor = Color.Blue;
            
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

        private void addPassenger_Click(object sender, EventArgs e)
        {
            AddPassenger addpassenger = new AddPassenger();
            this.Hide();
            addpassenger.Closed += (s, args) => this.Close();
            addpassenger.Show();
        }

        private void addAgent_Click(object sender, EventArgs e)
        {
            AddAgent addagent = new AddAgent();
            this.Hide();
            addagent.Closed += (s, args) => this.Close();
            addagent.Show();
        }

        private void addCompany_Click(object sender, EventArgs e)
        {
            AddCompany addcompany =new AddCompany();
            this.Hide();
            addcompany.Closed += (s, args) => this.Close();
            addcompany.Show();
        }
    }
}
