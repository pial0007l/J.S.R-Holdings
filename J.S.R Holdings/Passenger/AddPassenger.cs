using System;
using System.Drawing;
using System.Windows.Forms;
using J.S.R_Holdings.Entity;
using J.S.R_Holdings.Services;
using J.S.R_Holdings.Database;

namespace J.S.R_Holdings
{
    public partial class AddPassenger : MetroFramework.Forms.MetroForm
    {


        public AddPassenger()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateofbirthTextBox.Text = dateTimePicker1.Text;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            expireDateTextBox.Text = dateTimePicker2.Text;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            entryDateTextBox.Text = dateTimePicker3.Text;
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

        private void label14_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            passportTextBox.Text = "";
            dateofbirthTextBox.Text = "";
            expireDateTextBox.Text = "";
            addressTextBox.Text = "";
            FathersNameTextBox.Text = "";
            mobileNoTextBox.Text = "01";
            entryDateTextBox.Text = "";
            SerialNoTextBox.Text = "";
            AgentNameComboBox.Text = "";
            CompanyNameComboBox.Text = "";
         
        }

        private void addPerson()
        {
            Passenger passenger = new Passenger();
            if (  passportTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Enter Passport Number.");
            }
            else
            {
                if(nameTextBox.Text.ToString() == "")
                {
                    MessageBox.Show("Enter Name.");
                }
                else
                {
                    if(dateofbirthTextBox.Text.ToString() == "")
                    {
                        MessageBox.Show("Enter Date Of Birth.");
                    }
                    else
                    {
                        if(addressTextBox.Text.ToString() == "")
                        {
                            MessageBox.Show("Enter Address.");
                        }
                        else
                        {
                            if(expireDateTextBox.ToString()== "")
                            {
                                MessageBox.Show("Enter Expire Date.");
                            }
                            else
                            {
                                if(entryDateTextBox.ToString()== "")
                                {
                                    MessageBox.Show("Enter Entry Date.");
                                }
                                else
                                {
                                    try
                                    {
                                        passenger.Passport_No = passportTextBox.Text;
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Already Exist.");
                                    }
                                    passenger.Name = nameTextBox.Text;
                                    passenger.Date_of_birth = dateofbirthTextBox.Text;
                                    passenger.Address = addressTextBox.Text;
                                    passenger.Fathers_name = FathersNameTextBox.Text;
                                    passenger.Mobile_No = mobileNoTextBox.Text;
                                    passenger.Expire_date = expireDateTextBox.Text;
                                    passenger.Entry_Date = entryDateTextBox.Text;
                                    passenger.Agent_name = AgentNameComboBox.Text;
                                    passenger.Company_Name = CompanyNameComboBox.Text;
                                    passenger.Serial_no = SerialNoTextBox.Text;

                                    PassengerServices passengerservice = new PassengerServices();
                                    if (passengerservice.Add(passenger) == 1)
                                    {
                                        MessageBox.Show("Successfully Inserted");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.addPerson();
            }
            catch (Exception)
            {
                MessageBox.Show("Passport Number Already Exist.");
            }
        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet2.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter1.Fill(this.companyDataSet2.Company);
            // TODO: This line of code loads data into the 'agentDataSet2.Agent' table. You can move, or remove it, as needed.
            this.agentTableAdapter1.Fill(this.agentDataSet2.Agent);
            // TODO: This line of code loads data into the 'agentDataSet.Agent' table. You can move, or remove it, as needed.
            this.agentTableAdapter.Fill(this.agentDataSet.Agent);
            // TODO: This line of code loads data into the 'companyDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.companyDataSet.Company);
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet1.Company' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the '_J_S_R_HoldingsDATADataSet1.Agent' table. You can move, or remove it, as needed.

        }
    }
}
