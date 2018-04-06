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
    public partial class Delete : MetroFramework.Forms.MetroForm
    {
        public Delete()
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

        private void deletePassenger_Click(object sender, EventArgs e)
        {
            DeletePassenger deletepassenger = new DeletePassenger();
            this.Hide();
            deletepassenger.Closed += (s, args) => this.Close();
            deletepassenger.Show();
        }

        private void deleteAgent_Click(object sender, EventArgs e)
        {
            DeleteAgent deleteagent = new DeleteAgent();
            this.Hide();
            deleteagent.Closed += (s, args) => this.Close();
            deleteagent.Show();
        }

        private void DeleteCompany_Click(object sender, EventArgs e)
        {
            DeleteCompany deletecompany = new DeleteCompany();
            this.Hide();
            deletecompany.Closed += (s, args) => this.Close();
            deletecompany.Show();
        }
    }
}
