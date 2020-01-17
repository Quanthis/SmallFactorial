using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        { //7.
            int n, s=1;
            Console.Write("n= ");
            n = Convert.ToInt32(Console.ReadLine());
            
            
                int i = 1;
                while (i <= n)
                {
                    s *= i;
                    i++;
                }
                Console.WriteLine("n!={0}", s);
            
            
            Console.ReadKey();
        }
    }
}
