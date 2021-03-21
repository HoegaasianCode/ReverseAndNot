using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndAppend
{
    public class Reverser
    {
        private readonly string _ints;

        public Reverser(string ints)
        {
            _ints = ints;
        }

        public string ReverseString()
        {
            StringBuilder reverseInts = new();
            for (int i = _ints.Length - 1; i >= 0; i--)
            {
                char c = _ints[i];
                reverseInts.Append(c);
            }
            reverseInts.Append(_ints);
            return reverseInts.ToString();
        }
    }
}
