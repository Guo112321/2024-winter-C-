using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestException
{
    public class NumberException :Exception
    {
        public NumberException() { }
        
        public NumberException(string message) : base(string.Format("Invalid int value: {0}", message))
        {
            

        }

    }
}
