using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nfactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(num));
        }
        static int Sum(int sum)
        {
            if (sum == 1)
            {
                return sum;
            }
            return sum * Sum(sum - 1);
        }
    }
}
