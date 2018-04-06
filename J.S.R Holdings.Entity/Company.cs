using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.S.R_Holdings.Entity
{
    public class Company
    {
        private int id;
        private string name;
        private string salary;
        private string work_type;
        private string vacancy;

        public Company(){
            }
        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public string Salary
        {
            set { this.salary = value; }
            get { return this.salary; }
        }
        public string Work_type
        {
            set { this.work_type = value; }
            get { return this.work_type; }
        }
        public string Vacancy
        {
            set { this.vacancy = value; }
            get { return this.vacancy; }
        }
    }
}
