﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task1
{
    internal class WrongFormatException:Exception
    {
        public WrongFormatException(string message):base(message) { }
        
    }
}
