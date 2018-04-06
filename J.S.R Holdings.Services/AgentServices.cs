using J.S.R_Holdings.Database;
using J.S.R_Holdings.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.S.R_Holdings.Services
{
    public class AgentServices
    {
        private static AgentDataAccess agentdataaccess = new AgentDataAccess();

        public int Add(Agent agent)
        {
            return agentdataaccess.Add(agent);
        }
        public int Remove(Agent agent)
        {
            return agentdataaccess.Remove(agent);
        }
        public List<String> GetAllByName()
        {
            return agentdataaccess.GetAllByName();
        }
        public Agent GetByName(Agent agent)
        {
            return AgentServices.agentdataaccess.GetByMobileNo(agent);
        }
        public int Update(Agent agent)
        {
            return agentdataaccess.Update(agent);
        }
    }
}
