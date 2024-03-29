using System;

namespace ArrayProps
{
    class Program
    {
        static int[] Split(int traget, int[] banknote)
        {
            int[] fois = new int [9]; int surplus = 0;int x = 0;
            
            for (int i = 0; i < 9; i++) 
            {
                surplus = traget - banknote[i];
                if (surplus < 0)

                {
                    fois[i] = 0;
                    
                }
                else {
                    do {
                        traget = surplus;
                        surplus = (surplus - banknote[i]);
                        x++;
                        
                    } while (surplus > 0);
                    fois[i] = x;
                }
                
                x = 0;
            }    
            return  fois;
          
            
        }
         static int[] EmployeeFill(int[] Employee)
         {
            for (int i = 0; i < 5; i++)
            {
                Employee[i] =  int.Parse(Console.ReadLine());
            }
            return Employee;
         }

        static void Main(string[] args)
        {
            int[] banknote1 = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] number = new int[5];
            int[, ] result = new int[5, 9];
            EmployeeFill(number);
            for (int y = 0; y < 5; y++)
            {
                for (int i = 0; i < 9; i++)
                {
                    result[y, i] = Split(number[y], banknote1)[i];
                }
            };
              
            for (int y1 = 0; y1 < 5;y1++) { 

                for (int i2 = 0;i2 < 9; i2++) {
                    Console.Write(result[y1,i2]);
                    Console.Write(" ");
                }
               Console.WriteLine("");
            }
            Console.ReadKey();


        }
    }
}




 
