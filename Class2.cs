using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegats
{
    internal class Class2
    {
        public delegate int PowHandler(int x, int y);
        public delegate bool ResultHandler(int a);

        private int _resPow;

        public static bool _resultDel { get; private set; }

        public ResultHandler Calc(PowHandler pow, int a, int b, int c)
        {
            Class1 class1 = new Class1();
            pow = class1.Pow;
            _resPow = pow(a, b);

            ResultHandler res;
            res = Result;
            _resultDel = res(c);
            return res;
        }
        public bool Result(int x)
        {
            if (_resPow % x == 0)
            {
                return true;
            }
            return false;
        }
    }
}
