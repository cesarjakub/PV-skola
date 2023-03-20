﻿using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace massenger
{
    public class Database
    {
        private static SqlConnection connection = null;

        public Database()
        {

        }

        public static SqlConnection GetInstance()
        {
            if (connection == null)
            {
                SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
                consStringBuilder.UserID = ReadSetting("Name");
                consStringBuilder.Password = ReadSetting("Password");
                consStringBuilder.InitialCatalog = ReadSetting("Database");
                consStringBuilder.DataSource = ReadSetting("DataSource");
                consStringBuilder.ConnectTimeout = 30;
                connection = new SqlConnection(consStringBuilder.ConnectionString);
                connection.Open();
            }
            return connection;
        }
        public static void CloseConnection()
        {
            try
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            catch { }
            finally
            {
                connection = null;
            }
        }


        private static string ReadSetting(string key)
        {
            //nutno doinstalovat, VS nabídne doinstalaci samo
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[key] ?? "Not Found";
            return result;
        }

    }
}
