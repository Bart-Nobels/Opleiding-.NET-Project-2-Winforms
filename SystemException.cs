using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class SystemException : Exception
    {
        public SystemException(string boodschap) : base(boodschap) { }
    }
}
