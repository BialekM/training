﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Fabryka
{
    class Pasta : IOrder
    {
        public string GetComponent()
        {
            return "Pasta";
        }
    }
}
