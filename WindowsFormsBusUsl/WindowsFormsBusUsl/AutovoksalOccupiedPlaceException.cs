﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBusUsl
{
    class AutovoksalOccupiedPlaceException : Exception
    {
        public AutovoksalOccupiedPlaceException() : base("Не удалось припарковать")
        { }
    }
}
