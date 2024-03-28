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
            Console.Write("Write 10 numbers ");Console.WriteLine("");

            int num = 0; int[] n = new int[10]; int result = 0; int maxnm = 0;int m = 0;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    num = int.Parse(Console.ReadLine());

                } while (num < 0 || num > 100);
                n[i] = num;
            }
            for (int i3 = 0; i3 < 10; i3++)
            {
                if (i3 <= 1)
                {
                    maxnm = n[i3];
                    m = i3 + 1;
                }
                else
                {
                    result = n[i3] - maxnm;
                    if (result > 0)
                    {
                        maxnm = n[i3];
                        m = i3 + 1;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            for (int i2 = 0; i2 < 10; i2++)
            {
                Console.Write(n[i2]);
                Console.Write(" ");
            }
            Console.WriteLine("");
            Console.Write("MaX:"); Console.Write(maxnm);
            Console.Write("Number:"); Console.Write(m);
            Console.ReadKey();
        }
    }
}      
   
    
        
   



