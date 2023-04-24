using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server_počty.command
{
    public interface ICommand
    {
        string Execute();
    }
}
