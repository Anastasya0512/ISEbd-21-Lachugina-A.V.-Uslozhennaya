﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBusUsl
{
    public class AutovoksalAlreadyHaveException : Exception
    {
        public AutovoksalAlreadyHaveException() : base("На парковке уже есть такая машина")
        { }
    }
}
