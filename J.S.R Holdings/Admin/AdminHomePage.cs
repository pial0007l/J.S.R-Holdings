using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using J.S.R_Holdings.Transection;

namespace J.S.R_Holdings
{
    public partial class AdminHomePage :MetroFramework.Forms.MetroForm
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            this.Hide();
            add.Closed += (s, args) => this.Close();
            add.Show();
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
            Login login = new Login();
            this.Hide();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View view = new View();
            this.Hide();
            view.Closed += (s, args) => this.Close();
            view.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            this.Hide();
            delete.Closed += (s, args) => this.Close();
            delete.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateHomePage update = new UpdateHomePage();
            this.Hide();
            update.Closed += (s, args) => this.Close();
            update.Show();
        }

        private void Transection_Click(object sender, EventArgs e)
        {
            Transactions transaction = new Transactions();
            this.Hide();
            transaction.Closed += (s, args) => this.Close();
            transaction.Show();
        }
    }
}
