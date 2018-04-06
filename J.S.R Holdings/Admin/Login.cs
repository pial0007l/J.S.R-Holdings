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
    
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public static String passward;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton1_Click(object sender, EventArgs e)
        {
            string user_name = TextBox1.Text;
            passward = Textbox2.Text;
            if(user_name =="hafiz086" && passward == "banglades")
            {
                AdminHomePage adminhomepage = new AdminHomePage();
                this.Hide();
                adminhomepage.Closed += (s, args) => this.Close();
                adminhomepage.Show();

            }
            else
            {
                MessageBox.Show("Invalid User name and Passward");
            }
        }
    }
}
