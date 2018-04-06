using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J.S.R_Holdings.Transection
{
    public partial class Transactions : MetroFramework.Forms.MetroForm
    {
        public Transactions()
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

        private void label12_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
        }

        private void AddTransaction_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction();
            this.Hide();
            addTransaction.Closed += (s, args) => this.Close();
            addTransaction.Show();
        }

        private void RemoveTransaction_Click(object sender, EventArgs e)
        {
            RemoveTransaction removeTransaction = new RemoveTransaction();
            this.Hide();
            removeTransaction.Closed += (s, args) => this.Close();
            removeTransaction.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateTransaction updateTransaction = new UpdateTransaction();
            this.Hide();
            updateTransaction.Closed += (s, args) => this.Close();
            updateTransaction.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewTranssaction viewTransaction = new ViewTranssaction();
            this.Hide();
            viewTransaction.Closed += (s, args) => this.Close();
            viewTransaction.Show();
        }
    }
}
