using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegats
{
    internal class Class1
    {
        public delegate void ShowHandler(bool isTrue);

        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
