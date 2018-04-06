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
    public partial class UpdatePassengerDetails : MetroFramework.Forms.MetroForm
    {
        Passenger passenger;
        public UpdatePassengerDetails(Passenger passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.nameTextBox.Text=passenger.Name;
            this.passportTextBox.Text = passenger.Passport_No;
            this.dateofbirthTextBox.Text = passenger.Date_of_birth;
            this.addressTextBox.Text = passenger.Address;
            this.FathersNameTextBox.Text = passenger.Fathers_name;
            this.mobileNoTextBox.Text = passenger.Mobile_No;
            this.expireDateTextBox.Text = passenger.Expire_date;
            this.entryDateTextBox.Text = passenger.Entry_Date;
            this.SerialNoTextBox.Text = passenger.Serial_no;
        }

        private void UpdatePassengerDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet2.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.companyDataSet2.Company);
            // TODO: This line of code loads data into the 'agentDataSet2.Agent' table. You can move, or remove it, as needed.
            this.agentTableAdapter.Fill(this.agentDataSet2.Agent);

        }
        private void updatePassenger()
        {
            Passenger passenger = new Passenger();
            if (passportTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Enter Passport Number.");
            }
            else
            {
                if (nameTextBox.Text.ToString() == "")
                {
                    MessageBox.Show("Enter Name.");
                }
                else
                {
                    if (dateofbirthTextBox.Text.ToString() == "")
                    {
                        MessageBox.Show("Enter Date Of Birth.");
                    }
                    else
                    {
                        if (addressTextBox.Text.ToString() == "")
                        {
                            MessageBox.Show("Enter Address.");
                        }
                        else
                        {
                            if (expireDateTextBox.ToString() == "")
                            {
                                MessageBox.Show("Enter Expire Date.");
                            }
                            else
                            {
                                if (entryDateTextBox.ToString() == "")
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
                                    passenger.Status = StatusComboBox.Text;

                                    PassengerServices passengerservice = new PassengerServices();
                                    
                                    if (passengerservice.Update(passenger) == 1)
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
            this.updatePassenger();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            PassengerUpdate passengerUpdate = new PassengerUpdate();
            this.Hide();
            passengerUpdate.Closed += (s, args) => this.Close();
            passengerUpdate.Show();
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

        private void label13_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            this.Hide();
            adminHomePage.Closed += (s, args) => this.Close();
            adminHomePage.Show();
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
    }
}
