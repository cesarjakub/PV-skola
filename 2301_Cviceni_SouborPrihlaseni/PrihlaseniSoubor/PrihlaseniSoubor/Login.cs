using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrihlaseniSoubor
{
    public class Login
    {
        private string username;
        private string password;
        private string path = Directory.GetCurrentDirectory() + @"/db/uzivatele.txt";
        private Dictionary<string, string> dataDir = new Dictionary<string, string>();

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

        public Dictionary<string ,string> Datadir
        {
            get { return dataDir;}
            set { dataDir = value;}
        }

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public void safeToDict()
        {
            string[] lines = File.ReadAllLines(path);
            foreach(var x in lines)
            {
                Datadir.Add(x.Split("_")[0], x.Split("_")[1]);
            }
            
        }

        public bool getValidOptions(string name, string password)
        {
            safeToDict();
            foreach(KeyValuePair<string, string> kvp in Datadir)
            {
                if (kvp.Key == name && kvp.Value == password)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "Ahoj "+Username+", vaše heslo: "+Password;
        }
    }
}
