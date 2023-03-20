using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massenger
{
    public class Registrace
    {

        public Registrace()
        {

        }

        public void addToDB(Uzivatel uziv)
        {
            SqlConnection connection = Database.GetInstance();
            SqlCommand cmd = new SqlCommand($"insert into Uzivatel(jmeno, pass) Values('{uziv.Jmeno}','{uziv.Heslo}');", connection);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Uspesne pridano");
            Database.CloseConnection();
        }

        public bool isIN(Uzivatel uziv)
        {
            SqlConnection connection = Database.GetInstance();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM  Uzivatel WHERE pass = '{uziv.Heslo}'", connection);
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Database.CloseConnection();
                return true;
            }
            Database.CloseConnection();
            return false;
        }

        public bool logIN()
        {

            return false;
        }
    }
}
