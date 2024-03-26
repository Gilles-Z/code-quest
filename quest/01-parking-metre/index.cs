using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HELLO_WORLD {
    class Program
    {
        static void Main(string[] args)
        {
            float[] n = new float[3];
            for (int i = 0; i < 3; i++)
            {
                float num = 0;
                num = float.Parse(Console.ReadLine());
                n[i] = num;
            }
            foreach (float num in n)
            {
                byte money = 0;
                if (num <= 3)
                {
                    money = 2;
                }
                else if (num < 19)
                {
                    money = (byte)Math.Ceiling((num + 1) / 2);
                }
                else if (num <= 24)
                {
                    money = 10;
                }
                else
                {
                    Console.WriteLine("Fuck off");
                    continue;
                };
                Console.WriteLine(money);
            }
            Console.ReadKey();
        }
       
    }
}
