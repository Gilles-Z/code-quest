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
        static string LeftPad(string text, int length, string padToken) {
            if (padToken.Length > 1) {
                throw new ArgumentException("padToken can only accept a single character");
            };
            StringBuilder result = new StringBuilder("", length);
            int beforeFill = length - text.Length;
            while (result.Length < beforeFill) {
                result.Append(padToken);
            }
            result.Append(text);
            return result.ToString();
        }
        static void Main(string[] args) {
            float[] n = new float[3];
            for (int i = 0; i < 3; i++) {
                float num = 0;
                num = float.Parse(Console.ReadLine());
                n[i] = num;
            }
            Console.WriteLine("Customer   Hours   Charge");
            for (int i = 0; i < n.Length; i ++) {
                float num = n[i];
                Console.Write(LeftPad((i + 1).ToString(), 8, " "));
                Console.Write(LeftPad(num.ToString("n2"), 8, " "));
                byte money = 0;
                if (num <= 3) {
                    money = 2;
                }
                else if (num < 19) {
                    money = (byte)Math.Ceiling((num + 1) / 2);
                }
                else if (num <= 24) {
                    money = 10;
                }
                else {
                    Console.Write("    Fuck!");
                    continue;
                };
                Console.WriteLine(LeftPad(money.ToString("n2"), 9, " "));
            }
            Console.ReadKey();
        }
       
    }
}
