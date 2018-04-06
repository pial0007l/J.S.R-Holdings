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

namespace J.S.R_Holdings.Transection
{
    public partial class UpdateTransaction : MetroFramework.Forms.MetroForm
    {
        public UpdateTransaction()
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

        private void deleteCompanygridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateTransaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet.Transection' table. You can move, or remove it, as needed.
            this.transectionTableAdapter.Fill(this._J_S_R_HoldingsDATADataSet.Transection);

        }

        private void deleteCompanygridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AmmountTextBox.Text = deleteCompanygridview.CurrentRow.Cells[0].Value.ToString();
            AgentNameComboBox.Text = deleteCompanygridview.CurrentRow.Cells[1].Value.ToString();
            dateTextBox.Text = deleteCompanygridview.CurrentRow.Cells[2].Value.ToString();
            DetailsTextBox1.Text = deleteCompanygridview.CurrentRow.Cells[3].Value.ToString();
        }

        private void UpdateButton1_Click(object sender, EventArgs e)
        {
            this.Updates();
        }

        private void Updates()
        {
            AddTransaction atd = new AddTransaction();

            Tran tran = new Tran();
            if (AmmountTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Enter Ammount");
            }
            else if (dateTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Enter Date");
            }
            else
            {
                tran.Id = Convert.ToInt32(deleteCompanygridview.CurrentRow.Cells[4].Value.ToString());
                tran.Ammount = AmmountTextBox.Text.ToString();
                tran.AgentName = AgentNameComboBox.Text.ToString();
                tran.Date = dateTextBox.Text.ToString();
                tran.BankName = DetailsTextBox1.Text.ToString();

                TransactionsServices transervices = new TransactionsServices();
                if (transervices.Update(tran) == 1)
                {
                    MessageBox.Show("Successfull Updated");
                }
            }
        }
    }
}
