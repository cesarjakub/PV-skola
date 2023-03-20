using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Database
{
    public class ZamDAO : IDAO<Zam>
    {
        public void Delete(Zam zam)
        {
            SqlConnection conn = singletondb.GetInstance();

            using (SqlCommand command = new SqlCommand("DELETE FROM Osoby WHERE id = @id", conn))
            {
                command.Parameters.Add(new SqlParameter("@id", zam.ID));
                command.ExecuteNonQuery();
                zam.ID = 0;
            }
        }

        public IEnumerable<Zam> GetAll()
        {
            SqlConnection conn = singletondb.GetInstance();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Osoby", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Zam zam = new Zam(
                        Convert.ToInt32(reader[0].ToString()),
                        reader[1].ToString(),
                        reader[2].ToString()
                    );
                    yield return zam;
                }
                reader.Close();
            }
        }

        public Zam? GetByID(int id)
        {
            Zam? zam = null;
            SqlConnection connection = singletondb.GetInstance();
            // 1. declare command object with parameter
            using (SqlCommand command = new SqlCommand("SELECT * FROM Osoby WHERE id = @Id", connection))
            {
                // 2. define parameters used in command 
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Id";
                param.Value = id;

                // 3. add new parameter to command object
                command.Parameters.Add(param);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    zam = new Zam(
                        Convert.ToInt32(reader[0].ToString()),
                        reader[1].ToString(),
                        reader[2].ToString()
                        );
                }
                reader.Close();
            }

            return zam;

        }

        public void Save(Zam zam)
        {
            SqlConnection conn = singletondb.GetInstance();

            SqlCommand command = null;

            if (zam.ID < 1)
            {
                using (command = new SqlCommand("INSERT INTO Osoby (jmeno, prijmeni) VALUES (@jmeno, @prijmeni)", conn))
                {
                    command.Parameters.Add(new SqlParameter("@jmeno", zam.Jmeno));
                    command.Parameters.Add(new SqlParameter("@prijmeni", zam.Prijmeni));
                    command.ExecuteNonQuery();
                    //zjistim id posledniho vlozeneho zaznamu
                    command.CommandText = "Select @@Identity";
                    zam.ID = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            else
            {
                using (command = new SqlCommand("UPDATE Osoby SET jmeno = @jmeno, prijmeni = @prijmeni " +
                    "WHERE id = @id", conn))
                {
                    command.Parameters.Add(new SqlParameter("@id", zam.ID));
                    command.Parameters.Add(new SqlParameter("@jmeno", zam.Jmeno));
                    command.Parameters.Add(new SqlParameter("@prijmeni", zam.Prijmeni));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
