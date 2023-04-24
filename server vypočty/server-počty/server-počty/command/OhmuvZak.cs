using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server_počty.command
{
    public class OhmuvZak : ICommand
    {
        public string Execute()
        {
            VypoctyOhma vp = new VypoctyOhma(2.4, 4.5, 4.4);
            string temp = "proud";
            switch (temp)
            {
                case "odpor":
                    return vp.OdporR();
                    break;
                case "proud":
                    return vp.ProudI();
                    break;
                case "napeti":
                    return vp.NapetiU();
                    break;
                default:
                    return "Chyba";
            }
        }
    }
}
