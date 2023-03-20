using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Database
{
    public class Database
    {
        private SqlConnection connection;

        public Database()
        {
            {
                SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
                consStringBuilder.UserID = "sa";
                consStringBuilder.Password = "student";
                consStringBuilder.InitialCatalog = "test";
                consStringBuilder.DataSource = "PC954";
                consStringBuilder.ConnectTimeout = 30;
                try
                {
                    using (connection = new SqlConnection(consStringBuilder.ConnectionString))
                    {
                        connection.Open();
                        Console.WriteLine("Pripojeno");
                        //createTable();
                        //this.pridejData("Jirka", "Sykora", 17, DateTime.Now);
                        //this.pridejData("Simon", "Kulhzvy", 16, DateTime.Now);
                        //this.pridejData("Ondrej", "Bernard", 17, DateTime.Now);
                        vypisZTabulky();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void createTable()
        {
            string query = "create table Zam (id int identity(1,1) primary key, jmeno varchar(20) not null, prijmeni varchar(20) not null, vek int not null, datum_narozeni date not null)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void pridejData(string jmeno, string prijmeni, int vek, DateTime date)
        {
            string sqlFormattedDate = date.Date.ToString("yyyy-MM-dd");

            string query = "insert into Zam(jmeno, prijmeni, vek, datum_narozeni) values('"+jmeno+ "','" + prijmeni + "', "+vek+", '"+date+"')";
            SqlCommand command = new SqlCommand(query, connection);
            if(command.ExecuteNonQuery() == 1)
            {
                Console.WriteLine("pridano");
            }
            else
            {
                Console.WriteLine("chyba");
            }

        }

        public void vypisZTabulky()
        {
            string query = "select * from Zam";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("ID: "+reader[0].ToString() + " jmeno: " + reader[1].ToString()+ " prijmeni: " + reader[2].ToString() + " vek: " + reader[3].ToString()+" datum narozeni: "+reader[4].ToString());
                }
            }
        }
    }
}
