using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HELLO_WORLD
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            num = int.Parse(Console.ReadLine());
            int n = 0; int m = 0;
            while (n < num)
            {
                Console.Write("@");
                n++;
            }
            Console.WriteLine("");
            for (int i = 0; i < (num - 2); i++)
            {
                Console.Write("@");
                for (int k = 0; k < (num - 2); k++)
                {
                    Console.Write(" ");
                }
                Console.Write("@");
                Console.WriteLine("");



            }
            while (m < num)
            {
                Console.Write("@");
                m++;


               
            }
            Console.ReadKey();
        } 



    }
}
