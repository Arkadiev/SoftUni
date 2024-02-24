using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty() => Count == 0;

        public void AddRange(IEnumerable<string> elements)
        {
            foreach (string element in elements)
            {
                Push(element);
            }
        }
    }
}