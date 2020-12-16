using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBusUsl
{
    public class AutovoksalOverflowException : Exception
    {
        public AutovoksalOverflowException() : base("На автовокзале нет свободных мест")
        { }
    }
}
