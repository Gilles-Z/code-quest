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
        static string LeYeHangShu(string text, int length, string PadToken) { 
            StringBuilder resulat = new StringBuilder("",length);
            int beforeFille = (length - text.Length)/2;
                           
            for (int i = 0;i <beforeFille;i++)
            {
                resulat.Append(PadToken);
            }
            resulat.Append(PadToken);
            resulat.Append(text);
            for (int i = 0; i < 2; i++)
            {
                resulat.Append(PadToken);
            }
            resulat.Append(";");
            return resulat.ToString();  

        }
        
                        
        static void Main(string[] args) { 
        
                        float[] n = new float[3];
            
            for (int i = 0; i < 3; i++)
            {
                float num = 0;
                num = float.Parse(Console.ReadLine());
                n[i] = num;
            }
           Console.WriteLine("Customer  Hours  Charge");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(LeYeHangShu((i + 1).ToString(), 8, " "));
                Console.Write(LeYeHangShu(n[i].ToString(), 6, " "));
                int money = 0;
                if (n[i] <= 3)
                {
                    money = 2;
                }
                else if (n[i] < 19)
                {
                    money = (byte)Math.Ceiling((n[i] + 1) / 2);
                }
                else if (n[i] <= 24)
                {
                    money = 10;
                }
                else
                {
                    Console.WriteLine(LeYeHangShu("No", 7, " "));
                    continue;
                }
                Console.WriteLine(LeYeHangShu(money.ToString(), 7 , " "));
            }
            Console.ReadKey();

        }
        
     }
 }
   

        




