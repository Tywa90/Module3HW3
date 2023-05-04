using System.Data;

namespace Delegats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var class1 = new Class1();
            var class2 = new Class2();
            
            class2.Calc(new Class2.PowHandler(class1.Pow), 10, 5, 2);

            Class1.ShowHandler show;
            show = Show;
            show(Class2._resultDel);
            
        }

        public static void Show(bool isTrue)
        {
            Console.WriteLine(isTrue);
        }
    }
}