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
    public partial class AgentDetailsView : MetroFramework.Forms.MetroForm
    {
        public AgentDetailsView()
        {
            InitializeComponent();
            
            
        }

        private void AgentDetailsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet2.Agent' table. You can move, or remove it, as needed.
            

        }

        private void AgentDetailsView_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentDataSet.Agent' table. You can move, or remove it, as needed.
            this.agentTableAdapter.Fill(this.agentDataSet.Agent);
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet2.Agent' table. You can move, or remove it, as needed.


        }

        void showAllByName()
        {
            Passenger passenger = new Passenger();
            List<Passenger> passengerlist;

            PassengerServices passengerServices = new PassengerServices();

            String agentname = agentGridView.CurrentRow.Cells[0].Value.ToString();
            passenger.Agent_name = agentname;

            passengerlist = passengerServices.GetListByAgent(passenger);

            passengerGridView.DataSource = passengerlist;

            passengerGridView.Columns[2].Width = 200;
            passengerGridView.Columns[2].HeaderText = "Name";
             passengerGridView.Columns[1].Width = 200;
            passengerGridView.Columns[1].HeaderText = "Passport No";
            passengerGridView.Columns[0].Visible = false;
            passengerGridView.Columns[3].Visible = false;
            passengerGridView.Columns[4].Visible = false;
            passengerGridView.Columns[5].Visible = false;
            passengerGridView.Columns[6].Visible = false;
            passengerGridView.Columns[7].Visible = false;
            passengerGridView.Columns[8].Visible = false;
            passengerGridView.Columns[9].Visible = false;
            passengerGridView.Columns[10].Visible = false;
            passengerGridView.Columns[11].Visible = false;
            // passengerGridView.Columns[12].Visible = true;




        }

        private void agentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showAllByName();
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

        private void label13_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            View view = new View();
            this.Hide();
            view.Closed += (s, args) => this.Close();
            view.Show();
        }
    }
}
