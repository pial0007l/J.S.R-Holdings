using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using J.S.R_Holdings.Services;
using J.S.R_Holdings.Entity;

namespace J.S.R_Holdings.Transection
{
    public partial class AddTransaction : MetroFramework.Forms.MetroForm
    {
        public AddTransaction()
        {
            InitializeComponent();
        }
        public static int id;
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

        private void label12_Click(object sender, EventArgs e)
        {
            Transactions transaction = new Transactions();
            this.Hide();
            transaction.Closed += (s, args) => this.Close();
            transaction.Show();
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
            this.AmmountTextBox.Text = "";
            this.AgentNameComboBox.Text = "";
            this.dateTextBox.Text = "";
            this.DetailsTextBox1.Text = "";
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentDataSet.Agent' table. You can move, or remove it, as needed.
            this.agentTableAdapter.Fill(this.agentDataSet.Agent);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTextBox.Text = dateTimePicker1.Text;
        }
        private void Add()
        {
            id = id + 1;
            Tran tran = new Tran();
            if (AmmountTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Enter Ammount");
            }
            else if(dateTextBox.Text.ToString()==""){
                MessageBox.Show("Enter Date");
            }
            else
            {
                tran.Id = id;
                tran.Ammount = AmmountTextBox.Text.ToString();
                tran.AgentName = AgentNameComboBox.Text.ToString();
                tran.Date = dateTextBox.Text.ToString();
                tran.BankName = DetailsTextBox1.Text.ToString();

                TransactionsServices transervices = new TransactionsServices();
                if (transervices.Add(tran) == 1)
                {
                    MessageBox.Show("Insert Successfull");
                }
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Add();
        }
    }
}
