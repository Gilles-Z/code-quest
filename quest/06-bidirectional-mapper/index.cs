using System;

namespace Bidirectionnel
{

    class Program
    {
        private const string FILE_NAME = "dict.txt";
        string[] first = new string[5];
        string[] second = new string[5];
        int x = 0;
        static void Main(string[] args) 
        { 
        string SearchTerm = Console.ReadLine();
            bool PasCherchait = false; 
            if (!File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0}doesnt exist!", FILE_NAME);
                Console.WriteLine();
                return; 
            }
            using (StreamReader sr = File.OpenText(FILE_NAME)) 
            {
                string input ;
                while((input = sr.ReadLine()) != null)
                {
                    int commaSeperator = input.IndexOf(',');
                    if (commaSeperator < 0)
                    {
                        continue;
                    };
                    string key = input.Substring(0, commaSeperator);
                    string value = input.Substring(commaSeperator + 1);
                    if (key.Equals(SearchTerm)) 
                    {
                        PasCherchait= true; 
                        Console.WriteLine("[Anglais]{0}[Francais]{1}",key ,value);
                    }
                    else if (value.Equals(SearchTerm)) 
                    {
                        PasCherchait=(true);
                        Console.WriteLine("[Francais]{0}[Anglais]{1}", value, key);
                    }
                    


                }
                sr.Close(); 
            }
            if (!PasCherchait)
            {
                Console.WriteLine("Word {0} couldnot be found .", SearchTerm);

            }
            Console.ReadKey();



        }

    }
}
