using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace druhahodina
{
    public class Interval
    {
        private int horni_interval;
        private int dolni_interval;

        public Interval(int horni_interval, int dolni_interval)
        {
            this.horni_interval = horni_interval;
            this.dolni_interval = dolni_interval;
        }

        public int Horni_interval
        { 
            get { return horni_interval; } 
            set {
                if(value < dolni_interval)
                {
                    throw new Exception(" Error ");
                }
                horni_interval = value; 
            } 
        }

        public int Dolni_interval
        {
            get { return dolni_interval; }
            set
            {
                if(value > horni_interval)
                {
                    throw new Exception("Error");
                }
                dolni_interval = value;
            }
        }

        public bool nachaziSe(int cislo)
        {
            if (cislo <= horni_interval && cislo >= dolni_interval)
            {
                return true;
            }
            return false;
        }

        public string Prunik(Interval i2)
        {
            for (int i = dolni_interval; i <= horni_interval; i++)
            {
                Console.WriteLine(i+", ");
            }
            Console.WriteLine();

            for (int j = i2.dolni_interval; j <= i2.horni_interval; j++)
            {
                Console.WriteLine(j + ", ");
            }
            return "joe";
            
        }

         


    }
}
