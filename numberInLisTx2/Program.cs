using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberInLisTx2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            Console.WriteLine(Sum(inputs, 0));
        }
        static int Sum(List<int> list, int index)
        {
            if (index == list.Count - 1)
            {
                return list[index];
            }
            return list[index] + Sum(list, index+1);

        }
    }
}
