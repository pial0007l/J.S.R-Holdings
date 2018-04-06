using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using J.S.R_Holdings.Entity;
using System.Data.SqlClient;

namespace J.S.R_Holdings.Database
{
    public class CompanyDataAccess
    {
        public int Add(Company company)
        {
            string query = string.Format("INSERT INTO Company(CompanyName, Salary, WorkType, Vacancy, Id) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", company.Name, company.Salary,company.Work_type,company.Vacancy,company.Id);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(Company company)
        {
            string query = string.Format("DELETE FROM Company WHERE CompanyName = '{0}'", company.Name);
            return DataAccess.ExecuteQuery(query);
        }
        public List<String> GetAllByName()
        {
            string query = "SELECT CompanyName FROM Company";
            SqlDataReader reader = DataAccess.GetData(query);

            List<String> name = new List<String>();
            while (reader.Read())
            {
                name.Add(reader.GetString(0).ToString());
            }
            return name;
        }
        public int Update(Company company)
        {
            string query = string.Format("UPDATE Company SET CompanyName = '{0}', Salary='{1}', WorkType='{2}',Vacancy = '{3}' WHERE Id='{4}'", company.Name, company.Salary, company.Work_type,company.Vacancy, company.Id);
            return DataAccess.ExecuteQuery(query);
        }
    }
}
