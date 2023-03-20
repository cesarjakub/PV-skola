using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace SlovnikDatabaze
{
    public class ConnectToDb
    {
        private SqlConnection connection;
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public ConnectToDb(string state)
        {
            this.state = state;
            
            SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
            consStringBuilder.UserID = "sa";
            consStringBuilder.Password = "student";
            consStringBuilder.InitialCatalog = "slovnik";
            consStringBuilder.DataSource = "PC954";
            consStringBuilder.ConnectTimeout = 30;
            try
            {
                using (connection = new SqlConnection(consStringBuilder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("connected to DB");
                    Console.WriteLine("---------------");
                    //pridejData("tata", "dad");
                    //addToVazTab(5, 6);
                    switch (state)
                    {
                       case "CZ":
                          vypisZTabulkyCZ("mama");
                          break;
                        case "EN":
                           vypisZTabulkyEN("mom");
                           break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

        public void pridejData(string slovicko, string word)
        {
            string czslovo = "insert into CZ (slovicko) values ('"+slovicko+"')";
            string enslovo = "insert into EN(word) values('"+word+"')";
            SqlCommand command1 = new SqlCommand(czslovo, connection);
            SqlCommand command2 = new SqlCommand(enslovo, connection);
            if (command1.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
            {
                Console.WriteLine("pridano");
            }
            else
            {
                Console.WriteLine("chyba");
            }

        }

        public void addToVazTab(int czID, int enID)
        {
            string vazTabulka = "insert into preklad (cz_id, en_id) values (" + czID + "," + enID + ")";
            SqlCommand command = new SqlCommand(vazTabulka, connection);
            if (command.ExecuteNonQuery() == 1)
            {
                Console.WriteLine("pridano");
            }
            else
            {
                Console.WriteLine("chyba");
            }
        }

        public void vypisZTabulkyCZ(string slovo)
        {
            string query = "select preklad.id ,CZ.slovicko , EN.word from preklad inner join CZ on preklad.cz_id = CZ.id inner join EN on preklad.en_id = EN.id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[1].ToString() == slovo) {
                        Console.WriteLine("cesky: " + reader[1].ToString() + " ---> anglicky: " + reader[2].ToString());
                    }
                }
                reader.Close();
            }
        }

        public void vypisZTabulkyEN(string word)
        {
            string query = "select preklad.id ,CZ.slovicko , EN.word from preklad inner join CZ on preklad.cz_id = CZ.id inner join EN on preklad.en_id = EN.id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[2].ToString() == word)
                    {
                        Console.WriteLine("anglicky: " + reader[2].ToString() + " ---> cesky: " + reader[1].ToString());
                    }
                }
                reader.Close();
            }
        }
    }
}
