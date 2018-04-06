using J.S.R_Holdings.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.S.R_Holdings.Database
{
    public class AgentDataAccess
    {
        public int Add(Agent agent)
        {
            string query = string.Format("INSERT INTO Agent(AgentName, AgentMobileNo, AgentAddress) VALUES('{0}', '{1}', '{2}')", agent.Name, agent.Mobile_No, agent.Address);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(Agent agent)
        {
            string query = string.Format("DELETE FROM Agent WHERE AgentMobileNo = '{0}'", agent.Mobile_No);
            return DataAccess.ExecuteQuery(query);
        }
        public List<String> GetAllByName()
        {
            string query = "SELECT AgentName FROM Agent";
            SqlDataReader reader = DataAccess.GetData(query);

            List<String> name = new List<String>();
            while (reader.Read())
            {
                name.Add(reader.GetString(0));
            }
            return name;
        }
        public Agent GetByMobileNo(Agent agent)
        {
            string query = string.Format("SELECT * FROM Agent where AgentMobileNo = '{0}'",agent.Mobile_No );
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            if (reader.HasRows)
            {
                agent.Name = reader["AgentName"].ToString();
                agent.Mobile_No = reader["AgentMobileNo"].ToString();
                agent.Address = reader["AgentAddress"].ToString();
            }


                return agent;
        }
        public int Update(Agent agent)
        {
            string query = string.Format("UPDATE Agent SET AgentMobileNo = '{0}', AgentName='{1}', AgentAddress='{2}' WHERE AgentMobileNo='{3}'", agent.Mobile_No, agent.Name, agent.Address,agent.Mobile_No);
            return DataAccess.ExecuteQuery(query);
        }
    }
}
