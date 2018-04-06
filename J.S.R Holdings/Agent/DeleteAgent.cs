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
    public partial class DeleteAgent : MetroFramework.Forms.MetroForm
    {
        public DeleteAgent()
        {
            InitializeComponent();
        }

        private void DeleteAgent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentDataSet.Agent' table. You can move, or remove it, as needed.
            this.agentTableAdapter.Fill(this.agentDataSet.Agent);
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet2.Agent' table. You can move, or remove it, as needed.


        }

        private void deletepassengergridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Agent agent = new Agent();
            AgentServices agentservices = new AgentServices();

            String mobileNo = deletepassengergridview.CurrentRow.Cells[1].Value.ToString();
            agent.Mobile_No = mobileNo;

            if (agentservices.Remove(agent) == 1)
            {
                
                MessageBox.Show("Successfully Deleted");
            }
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

        private void refresh_Click(object sender, EventArgs e)
        {
            DeleteAgent deleteagent = new DeleteAgent();
            this.Hide();
            deleteagent.Closed += (s, args) => this.Close();
            deleteagent.Show();
        }
    }
}
