using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1AFinal
{
    class AreaCircumferenceOfACircle
    {
        static void Main(string[] args)
        {
            int r;
            double A;
            Console.WriteLine("Enter radius value here to calculate the area of the circle:");
            r = Convert.ToInt32(Console.ReadLine());
            A = (Math.PI) * r * r;
            Console.WriteLine("The area of the circle of the radius supplied is =" + A);

            //circumference of a circle: 2πr
            Console.WriteLine("Enter radius value again to calculate the circumference of the circle");
            Console.ReadLine();
            A = (Math.PI) * 2 * r;
            Console.WriteLine("The circumference of the circle of the radius supplied is =" + A);
            Console.ReadLine();
        }
    }
}
