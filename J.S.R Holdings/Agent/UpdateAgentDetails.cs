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
    public partial class UpdateAgentDetails : MetroFramework.Forms.MetroForm
    {
        Agent agent;
        public UpdateAgentDetails(Agent agent)
        {
            InitializeComponent();
            this.agent = agent;
            this.agentnameTextBox.Text = agent.Name;
            this.agentmobileNoTextBox.Text = agent.Mobile_No;
            this.agentaddressTextBox.Text = agent.Address;
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

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Blue;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.ForeColor = Color.Black;
        }

        private void label12_Click(object sender, EventArgs e)
        {
           Agent_Update  agentUpdate = new Agent_Update();
            this.Hide();
            agentUpdate.Closed += (s, args) => this.Close();
            agentUpdate.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            this.Hide();
            adminHomePage.Closed += (s, args) => this.Close();
            adminHomePage.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            agentaddressTextBox.Text = "";
            agentnameTextBox.Text = "";
            agentmobileNoTextBox.Text = "";
        }

        private void updateAgent()
        {
            Agent agent = new Agent();
            if(agentmobileNoTextBox.Text.ToString() =="")
            {
                MessageBox.Show("Enter Mobile No.");
            }
            else 
            {
                if (agentnameTextBox.Text.ToString() == "")
                {
                    MessageBox.Show("Enter Name");
                }
                else
                {
                    if (agentaddressTextBox.Text.ToString() == "")
                    {
                        MessageBox.Show("Enter Address");
                    }
                    else
                    {
                        try
                        {
                            agent.Mobile_No = agentmobileNoTextBox.Text;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Already Exist");
                        }
                        agent.Address = agentaddressTextBox.Text;
                        agent.Name = agentnameTextBox.Text;

                         AgentServices agentservices = new AgentServices();

                        if (agentservices.Update(agent)==1)
                        {
                            MessageBox.Show("Successfully Updated");
                        }
                        else
                        {
                            MessageBox.Show("Update Failed");
                        }
                    }
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.updateAgent();
        }
    }
}
