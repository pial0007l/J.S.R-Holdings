using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using J.S.R_Holdings.Entity;
using J.S.R_Holdings.Services;

namespace J.S.R_Holdings
{
    public partial class Agent_Update :MetroFramework.Forms.MetroForm
    {
        public Agent_Update()
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

        private void Agent_Update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentDataSet2.Agent' table. You can move, or remove it, as needed.
            this.agentTableAdapter.Fill(this.agentDataSet2.Agent);

        }

        private void agentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Agent agent = new Agent();
            AgentServices agentServices = new AgentServices();

            String agentMobileNo = agentupdateGridView.CurrentRow.Cells[1].Value.ToString();
            agent.Mobile_No = agentMobileNo;


            UpdateAgentDetails updateagentdetails = new UpdateAgentDetails(agentServices.GetByName(agent));
            this.Hide();
            updateagentdetails.Closed += (s, args) => this.Close();
            updateagentdetails.Show();
        }
    }
}
