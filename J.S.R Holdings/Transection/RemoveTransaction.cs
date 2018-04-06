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
    public partial class RemoveTransaction : MetroFramework.Forms.MetroForm
    {
        public RemoveTransaction()
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

        private void RemoveTransaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet.Transection' table. You can move, or remove it, as needed.
            this.transectionTableAdapter.Fill(this._J_S_R_HoldingsDATADataSet.Transection);

        }

        private void deleteCompanygridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Tran trans = new Tran();
            TransactionsServices transervices = new TransactionsServices();
            String companyId = deleteCompanygridview.CurrentRow.Cells[4].Value.ToString();
            int c_id = Convert.ToInt32(companyId);
            trans.Id = c_id;
            if (transervices.Remove(trans) == 1)
            {

                MessageBox.Show("Successfully Deleted");
            }
        }
    }
}
