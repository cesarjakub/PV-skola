using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrihlaseniSoubor
{
    public class newAccount
    {
        private string username;
        private string password;
        private string path = Directory.GetCurrentDirectory() + @"/db/uzivatele.txt";

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public newAccount(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public void writeToFile()
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.Write(Username+"_"+Password+"\n");
            sw.Close();
        }
    }
}
