﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitades
{
    public class PickUp
    {
        public override bool Equals(object obj)
        {
            return obj is PickUp;
        }
    }
}
