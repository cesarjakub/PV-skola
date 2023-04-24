using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server_počty
{
    public class VypoctyOhma
    {
        public double I { get; set; }
        public double R { get; set; }
        public double U { get; set; }

        public VypoctyOhma(double i, double r, double u)
        {
            I = i;
            R = r;
            U = u;
        }

        public string OdporR()
        {
            string temp;
            double vyp = 0;
            vyp = this.U / this.I;
            temp = vyp.ToString();
            return "R = "+ temp;
        }
        public string ProudI()
        {
            string temp;
            double vyp = 0;
            vyp = this.U / this.R;
            temp = vyp.ToString();
            return "I = " + temp;
        }
        public string NapetiU()
        {
            string temp;
            double vyp = 0;
            vyp = this.I * this.R;
            temp = vyp.ToString();
            return "U = " + temp;
        }
    }
}
