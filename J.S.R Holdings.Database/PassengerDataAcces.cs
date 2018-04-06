using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using J.S.R_Holdings.Entity;
using System.Data.SqlClient;

namespace J.S.R_Holdings.Database
{
    public class PassengerDataAcces
    {
        public int Add(Passenger passenger)
        {
            string query = string.Format("INSERT INTO Passenger(PassportNo, PassengerName, DateOfBirth, PassengerAddress, FathersName, MobileNo, ExpireDate, EntryDate, AgentsName, CompanysName, SerialNo) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", passenger.Passport_No,passenger.Name,passenger.Date_of_birth,passenger.Address,passenger.Fathers_name,passenger.Mobile_No,passenger.Expire_date,passenger.Entry_Date,passenger.Agent_name,passenger.Company_Name,passenger.Serial_no);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(Passenger passenger)
        {
            string query = string.Format("DELETE FROM Passenger WHERE PassportNo = '{0}'", passenger.Passport_No);
            return DataAccess.ExecuteQuery(query);
        }
        public int Update(Passenger passenger)
        {
            string query = string.Format("UPDATE Passenger SET PassportNo = '{0}', PassengerName='{1}', DateOfBirth='{2}', PassengerAddress='{3}', FathersName='{4}', MobileNo='{5}', ExpireDate='{6}', EntryDate='{7}', AgentsName='{8}', CompanysName='{9}', SerialNo='{10}', Status='{11}' WHERE PassportNo='{12}'", passenger.Passport_No,passenger.Name,passenger.Date_of_birth,passenger.Address,passenger.Fathers_name,passenger.Mobile_No,passenger.Expire_date,passenger.Entry_Date,passenger.Agent_name,passenger.Company_Name,passenger.Serial_no,passenger.Status,passenger.Passport_No);
            return DataAccess.ExecuteQuery(query);
        }

        public Passenger GetByPassport(Passenger passenger)
        {
            string query = string.Format("SELECT * FROM Passenger where PassportNo = '{0}'", passenger.Passport_No);
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();


            if (reader.HasRows)
            {
            //    passenger.Passport_No = reader["PassportNo"].ToString();
                passenger.Name = reader["PassengerName"].ToString();
                passenger.Date_of_birth = reader["DateOfBirth"].ToString();
                passenger.Address = reader["PassengerAddress"].ToString();
                passenger.Fathers_name = reader["FathersName"].ToString();
                passenger.Expire_date = reader["ExpireDate"].ToString();
                passenger.Entry_Date = reader["EntryDate"].ToString();
                passenger.Agent_name = reader["AgentsName"].ToString();
                passenger.Company_Name = reader["CompanysName"].ToString();
                passenger.Serial_no = reader["SerialNo"].ToString();
                passenger.Mobile_No = reader["MobileNo"].ToString();

            }
            return passenger;
        }

        public List<Passenger> GetListByAgent(Passenger passenger)
        {
            string query = string.Format("SELECT PassengerName, PassportNo FROM Passenger where AgentsName = '{0}'", passenger.Agent_name);
            SqlDataReader reader = DataAccess.GetData(query);

            List<Passenger> PList = new List<Passenger>();
            while (reader.Read())
            {
                Passenger passenger1 = new Passenger();
                passenger1.Name = reader.GetString(0);
                passenger1.Passport_No = reader.GetString(1);
                PList.Add(passenger1);
                
            }
            return PList;
        }
        public List<Passenger> GetListByCompany(Passenger passenger)
        {
            string query = string.Format("SELECT PassengerName, PassportNo FROM Passenger where CompanysName = '{0}'", passenger.Company_Name);
            SqlDataReader reader = DataAccess.GetData(query);

            List<Passenger> PList = new List<Passenger>();
            while (reader.Read())
            {
                Passenger passenger1 = new Passenger();
                passenger1.Name = reader.GetString(1);
                passenger1.Passport_No = reader.GetString(0);
                PList.Add(passenger1);
            }
            return PList;
        }
        public List<Passenger> GetListByPassport(Passenger passenger)
        {
            string query = string.Format("SELECT PassengerName FROM Passenger where PassportNo = '{0}'", passenger.Passport_No);
            SqlDataReader reader = DataAccess.GetData(query);

            List<Passenger> PList = new List<Passenger>();
            while (reader.Read())
            {
                Passenger passenger1 = new Passenger();
                passenger1.Name = reader.GetString(0);
      
                PList.Add(passenger1);

            }
            return PList;
        }
    }
}
