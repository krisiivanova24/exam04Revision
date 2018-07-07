using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Print(number);
        }
        static void Print(int num)
        {
            if (num==0)
            {
                return;
            }
            Console.WriteLine(new string('*', num));
            Print(num-1);
            Console.WriteLine(num);
            Console.WriteLine(new string('#', num));
        }
    }
}
