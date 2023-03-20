using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrihlaseniSoubor
{
    public class Kontrola
    {
        private newAccount nc;
        private Login login;
    
        public newAccount Nc
        {
            get { return nc; }
            set { nc = value; }
        }

        public Login Login 
        { 
            get { return login; }
            set { login = value; }
        }

        public Kontrola()
        {
        }

        public string CreateNewAccount(string username, string password)
        {
            nc = new newAccount(username, password);
            nc.writeToFile();
            return "Jej máte vytvořenej účet!!!";
        }

        public string LoginToAccount(string username, string password)
        {
            login = new Login(username, password);
            if (login.getValidOptions(username, password))
            {
                return login.ToString();
            }
            else
            {
                return "Jaj neco je špatně";
            }
            
        }
    }
}
