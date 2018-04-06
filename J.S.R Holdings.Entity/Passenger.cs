using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.S.R_Holdings.Entity
{
   public class Passenger
    {
        private String passport_No;
        private String name;
        private String date_of_birth;
        private String address;
        private String fathers_name;
        private String mobile_no;
        private String expire_date;
        private String entry_date;
        private String agent_name;
        private String company_name;
        private String serial_no;
        private String status;

        public Passenger()
        {

        }
        public String Status
        {
            set { this.status = value; }
            get { return this.status; }
        }
        public string Passport_No
        {
            set { this.passport_No = value; }
            get { return this.passport_No; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public string Date_of_birth
        {
            set { this.date_of_birth = value; }
            get { return this.date_of_birth; }
        }
        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public string Fathers_name
        {
            set { this.fathers_name = value; }
            get { return this.fathers_name; }
        }
        public string Mobile_No
        {
            set { this.mobile_no = value; }
            get { return this.mobile_no; }
        }
        public string Expire_date
        {
            set { this.expire_date = value; }
            get { return this.expire_date; }
        }
        public string Entry_Date
        {
            set { this.entry_date = value; }
            get { return this.entry_date; }
        }
        public string Agent_name
        {
            set { this.agent_name = value; }
            get { return this.agent_name; }
        }
        public string Company_Name
        {
            set { this.company_name = value; }
            get { return this.company_name; }
        }
        public string Serial_no
        {
            set { this.serial_no = value; }
            get { return this.serial_no; }
        }
    }
}
