using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA.FibonacciSequence
{
    public class FibonacciSequenceClass
    {
        public  int GetFibonacciNumber(int n)
        {
            if(n < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (n <= 1)
            {
                return n;
            }

            return GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
        }
    }
}
