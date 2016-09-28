using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TessmerBoatCalcThingy
{
    class Program
    {
        static double angle;
        const double bottomMeasure = 7.2;
        const double prism_length = 19;
        static void Main(string[] args)
        {
            //Calculate the angle of the triangles that are part of the trapezoid.
            angle = Math.Acos(4.5 / 5);

            for (double x = 0.1; x <= 4.5; x += 0.05)
            {
                double vol = calculateVolume(calculateArea(x));
                Console.WriteLine("Input height: {0}", x);
                Console.WriteLine("Calculated volume: " + vol);
                Console.WriteLine("Total volume: {0}", vol + 362.52);
                Console.WriteLine("");
            }
        }
        /// <summary>
        /// Calculates the total volume of the prism.
        /// </summary>
        /// <param name="area">The area of the base of the prism.</param>
        /// <param name="length">The height of the prism.</param>
        /// <returns>The total volume of the prism.</returns>
        private static double calculateVolume(double area)
        {
            return area * prism_length;
        }
        private static double calculateArea(double measure)
        {
            double tan = Math.Tan(angle) * 4.5;
            double topMeasure = 2 * tan + bottomMeasure;
            double area = ((topMeasure + bottomMeasure) / 2) * measure;
            return area;
        }
        /// <summary>
        /// Converts radians to degrees.
        /// </summary>
        /// <param name="rad">Measure in radians.</param>
        /// <returns>Measure in degrees.</returns>
        private static double radToDeg(double rad)
        {
            return rad * 180 / Math.PI;
        }
    }
}
