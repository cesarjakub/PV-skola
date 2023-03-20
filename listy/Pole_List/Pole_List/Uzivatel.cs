using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Pole_List
{
    public class Uzivatel: IComparable<Uzivatel>
    {
        private string nickname;
        private string heslo;

        public Uzivatel(string nickname, string heslo)
        {
            Nickname = nickname;
            Heslo = heslo;
        }

        public string Nickname
        {
            get { return nickname; }
            set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("Nickname musi mit minimalne 3 znaky");
                }
                nickname = value;
            }
        }

        public string Heslo
        {
            get { return heslo; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Heslo musi mit minimalne 5 znaku");
                }
                heslo = value;
            }
        }

        public int CompareTo(Uzivatel? other)
        {
            if(other == null) return -1;
            return this.nickname.CompareTo(other.nickname);
        }

        public override string? ToString()
        {
            return "Nickname: "+nickname + " heslo: "+heslo;
        }



        
    }
}
