using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELLO_WORLD {
    class Program
    {
        static void Main(string[] args)
        {
            for (float i = 0; i < 3; i ++)
            { byte money = 0;
                float num = 0;
                num = float.Parse(Console.ReadLine());
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
                else {
                    Console.WriteLine("Fuck off");
                    continue;

                };
            Console.WriteLine(money);
            };
            Console.ReadKey();
        }
       
    }
}
