using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfAHemisphere
{
    class VolumeOfAHemisphere
    {
        static void Main(string[] args)
        {
            int r;
            double V;
            Console.WriteLine("Enter the radius value here to calculate the volume of the sphere:");
            r = Convert.ToInt32(Console.ReadLine());
            V = 2 * Math.PI * Math.Pow(r, 3) / 3;
            Console.WriteLine("The volume of the sphere of the radius supplied is =" + V);
            Console.ReadLine();
        }
    }
}
