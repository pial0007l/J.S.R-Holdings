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
    public partial class AddAgent : MetroFramework.Forms.MetroForm
    {
        public AddAgent()
        {
            InitializeComponent();
        }

        private void label12_MouseClick(object sender, MouseEventArgs e)
        {
            Add add = new Add();
            this.Hide();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
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

        private void label14_Click(object sender, EventArgs e)
        {
            agentnameTextBox.Text = "";
            agentaddressTextBox.Text = "";
            agentmobileNoTextBox.Text = "";            
        }

        private void Add()
        {
            Agent agent = new Agent();
            if (agentmobileNoTextBox.Text.ToString() == ""|| agentmobileNoTextBox.Text.ToString() == "01")
            {
                MessageBox.Show("Enter Agent Mobile Number");
            }
            else
            {
                if (agentnameTextBox.Text.ToString() == "")
                {
                    MessageBox.Show("Enter Agent Name");
                }
                else
                {
                    if (agentaddressTextBox.Text.ToString() == "")
                    {
                        MessageBox.Show("Enter agent Address");
                    }
                    else
                    {
                        agent.Name = agentnameTextBox.Text;
                        agent.Mobile_No = agentmobileNoTextBox.Text;
                        agent.Address = agentaddressTextBox.Text;

                        AgentServices agentservices = new AgentServices();
                        if (agentservices.Add(agent) == 1)
                        {
                            MessageBox.Show("Adding Complete");
                        }
                    }
                }
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Add();
            }
            catch(Exception)
            {
                MessageBox.Show("Agent Already Exist");
            }
        }
    }
}
