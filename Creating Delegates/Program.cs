using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Delegates
{
    class Program
    {
        delegate int del(int x, int y);

        delegate void multicastdel(int x, int y);

        static void Main(string[] args)
        {
            Mark m = new Mark();
            Mike mm = new Mike();

            del d = m.AddNumbers;
            multicastdel md;

            Console.WriteLine(d(3, 4));

            d = m.MultiplyNumbers;

            Console.WriteLine(d(5, 5));

            d = m.RandomMath;

            Console.WriteLine(d(2, 2));

            md = mm.AddNumbers;           

            md += mm.MultiplyNumbers;

            md += mm.RandomMath;

            md(5, 5);

            md -= mm.AddNumbers;

            md(5, 5);
        }
    }

    public class Mark
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }
        public int RandomMath(int x, int y)
        {
            return x + (y * 3);
        }
    }

    public class Mike
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine($"a + b = {a + b}");
        }
        public void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine($"a * b = {a * b}");
        }
        public void RandomMath(int x, int y)
        {
            Console.WriteLine($"x + ( y * 3 ) = {x + (y * 3)}");
        }
    }
}
