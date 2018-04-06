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
    public partial class ViewTranssaction : MetroFramework.Forms.MetroForm
    {
        public ViewTranssaction()
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
            Transactions transaction = new Transactions();
            this.Hide();
            transaction.Closed += (s, args) => this.Close();
            transaction.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            AdminHomePage adminhomepage = new AdminHomePage();
            this.Hide();
            adminhomepage.Closed += (s, args) => this.Close();
            adminhomepage.Show();
        }

        private void ViewTranssaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet.Transection' table. You can move, or remove it, as needed.
            this.transectionTableAdapter.Fill(this._J_S_R_HoldingsDATADataSet.Transection);

        }

        void showAllByAgentName()
        {
            Tran trans = new Tran();
            List<Tran> transactionlist;

            TransactionsServices transactionsServices = new TransactionsServices();

            String agentname = viewtransactiongridview.CurrentRow.Cells[1].Value.ToString();
            trans.AgentName = agentname;

            transactionlist = transactionsServices.GetListByAgent(trans);

            viewByAgentGridView.DataSource = transactionlist;

            //viewByAgentGridView.Columns[1].Width = 200;
            //viewByAgentGridView.Columns[1].HeaderText = "Ammount";
            //viewByAgentGridView.Columns[2].Width = 200;
            //viewByAgentGridView.Columns[2].HeaderText = "Date";
            //viewByAgentGridView.Columns[0].Visible = false;
           // viewByAgentGridView.Columns[3].Visible = false;
            //viewByAgentGridView.Columns[4].Visible = false;
        }

        private void viewtransactiongridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.showAllByAgentName();
        }
    }
}
