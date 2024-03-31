using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestException
{
    public class FloatException : Exception
    {
        public FloatException() { }
        public FloatException(string message) : base(string.Format("Invalid Float value: {0}", message)) { }
    }
}
