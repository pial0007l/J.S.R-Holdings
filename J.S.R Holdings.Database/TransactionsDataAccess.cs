using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using J.S.R_Holdings.Entity;
using System.Data.SqlClient;

namespace J.S.R_Holdings.Database
{
    public class TransactionsDataAccess
    {

        public int Add(Tran transactions)
        {
            string query = string.Format("INSERT INTO Transection(Ammount, AgentName, Date, BankName, Id) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", transactions.Ammount, transactions.AgentName, transactions.Date, transactions.BankName, transactions.Id);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(Tran transactions)
        {
            string query = string.Format("DELETE FROM Transection WHERE Id = '{0}'", transactions.Id);
            return DataAccess.ExecuteQuery(query);
        }
        public int Update(Tran transactions)
        {
            string query = string.Format("UPDATE Transection SET Ammount = '{0}', AgentName='{1}', Date='{2}',BankName = '{3}' WHERE Id='{4}'", transactions.Ammount, transactions.AgentName, transactions.Date, transactions.BankName, transactions.Id);
            return DataAccess.ExecuteQuery(query);
        }
        
     
        public List<Tran> GetListByAgent(Tran trans)
        {
            string query = string.Format("SELECT Ammount, Date FROM Transection where AgentName = '{0}'", trans.AgentName);
            SqlDataReader reader = DataAccess.GetData(query);

            List<Tran> PList = new List<Tran>();
            while (reader.Read())
            {
                Tran trans1 = new Tran();
                trans1.Ammount = reader.GetString(2).ToString();
                //trans1.Date = reader.GetString(1).ToString();
                PList.Add(trans1);

            }
            return PList;
        }
        public List<Tran> GetListByDate(Tran trans)
        {
            string query = string.Format("SELECT Ammount, AgentNeme FROM Transection where Date = '{0}'", trans.Date);
            SqlDataReader reader = DataAccess.GetData(query);

            List<Tran> PList = new List<Tran>();
            while (reader.Read())
            {
                Tran trans2 = new Tran();
                trans2.Ammount = reader.GetString(1);
                trans2.AgentName = reader.GetString(2);
                PList.Add(trans2);

            }
            return PList;
        }
    }
}
