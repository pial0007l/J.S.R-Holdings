using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.S.R_Holdings.Entity
{
   public class Agent
    {
        private string name;
        private string mobile_no;
        private string address;

        public Agent()
        {

        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public string Mobile_No
        {
            set { this.mobile_no = value; }
            get { return this.mobile_no; }
        }

        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
    }
}
