﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_17._4.command
{
    public class Last : ICommand
    {
        public string Execute()
        {
            return "help, time";
        }
    }
}
