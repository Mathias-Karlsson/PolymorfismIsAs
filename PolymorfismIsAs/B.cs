﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorfismIsAs
{
    class B: A
    {
        public new string Description()
        {
            return "Objektet är av typen B";
        }
    }
}
