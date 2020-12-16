using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBusUsl
{
    public class AutovoksalNotFoundException : Exception
    {
        public AutovoksalNotFoundException(int i) : base("Не найден автобус по месту " + i)
        { }
    }
}
