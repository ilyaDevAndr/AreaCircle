using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double radius; double area;
            radius = 25.0;
            area = radius * radius * 3.1416;
            Console.WriteLine();
            Console.WriteLine("Площадь круга " + area);
            Console.WriteLine("Нажмите ENTER чтобы выйти из программы");
            Console.Read();

        }
    }
}
