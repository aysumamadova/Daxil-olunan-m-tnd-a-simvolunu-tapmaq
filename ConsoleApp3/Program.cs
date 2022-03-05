using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Soz daxil edin : ");
            string soz = Convert.ToString(Console.ReadLine());
            char herf = 'a';
            int sum = 0;

            for (int i = 0; i < soz.Length; i++)
            {
                if (soz[i] == herf)
                {
                    sum++;
                }

            }
            if (sum > 0)
            {
                Console.WriteLine("a herfi var");
            }
            else
            {
                Console.WriteLine("a herfi yoxdu");
            }
        }
    }
}
