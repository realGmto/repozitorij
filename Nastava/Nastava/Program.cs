using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nastava
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("upisi do koliko zelis ici");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                if (i % 4 == 3 || i % 4 == 0)
                    Console.WriteLine(i+" ");
            }
            Console.ReadKey();
        }
    }
}
