using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticFormula
{
    class QuadraticFormula
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("This is a Quadratic Formula Program");
            Console.WriteLine("Type the value for a");
            Console.ReadLine();
            Console.WriteLine("Type the value of b");
            Console.ReadLine();
            Console.WriteLine("Type the value for c");
            Console.ReadLine();
        }
        static double quadForm(int a, int b, int c, bool pos)
        {
            int x = 0;
            if (pos)
                x = ((-b + (int)(Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a));
            else
                x = ((-Math.Abs(b) - (int)(Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)))) / (2 * a));
            return x;
        }
    }
}
