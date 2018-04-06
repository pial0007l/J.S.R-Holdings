using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.S.R_Holdings.Entity
{
    public class Tran
    {
        private int id;
        private string ammount;
        private string agentName;
        private string date;
        private string bankName;

        public Tran()
        {

        }

        public string Ammount { get => ammount; set => ammount = value; }
        public int Id { get => id; set => id = value; }
        public string AgentName { get => agentName; set => agentName = value; }
        public string Date { get => date; set => date = value; }
        public string BankName { get => bankName; set => bankName = value; }
    }
}
