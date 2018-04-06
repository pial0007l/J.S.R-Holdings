using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using J.S.R_Holdings.Database;
using J.S.R_Holdings.Entity;

namespace J.S.R_Holdings.Services
{
    public class CompanyServices
    {
        CompanyDataAccess companydataaccess = new CompanyDataAccess();

         public int Add(Company company)
        {
            return companydataaccess.Add(company);
        }
        public int Remove(Company company)
        {
            return companydataaccess.Remove(company);
        }
        public List<String> GetAllByName()
        {
            return companydataaccess.GetAllByName();
        }
        public int Update(Company company)
        {
            return companydataaccess.Update(company);
        }
    }
}
