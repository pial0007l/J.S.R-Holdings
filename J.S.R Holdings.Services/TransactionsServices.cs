using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using J.S.R_Holdings.Database;
using J.S.R_Holdings.Entity;

namespace J.S.R_Holdings.Services
{
    public class TransactionsServices
    {
        TransactionsDataAccess transactionsDataAccess = new TransactionsDataAccess();

        public int Add(Tran tran)
        {
            return transactionsDataAccess.Add(tran);
        }
        public int Remove(Tran tran)
        {
            return transactionsDataAccess.Remove(tran);
        }
        public List<Tran> GetListByAgent(Tran trans)
        {
            return transactionsDataAccess.GetListByAgent(trans);
        }
        public List<Tran> GetListByDate(Tran trans)
        {
            return transactionsDataAccess.GetListByDate(trans);
        }

        public int Update(Tran tran)
        {
            return transactionsDataAccess.Update(tran);
        }
    }
}
