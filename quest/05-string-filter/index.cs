using System;

namespace Horny {
    class Program {
        static string[] Horny(string[] text)
        {
            string[] Mots = new string[5];
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Mots[i] = Console.ReadLine();
                } while (Mots[i].Length < 16);
            }
            return Mots;
        }
        static void Main(string[] args)
        {
            string suffix = "er";
            string[] Putin = new string[5];
            Console.Write("\n");
            Horny(Putin);
            foreach (string item in Putin)
            {
                if (item.EndsWith(suffix))
                {
                    Console.WriteLine("Suffix \"{0}\" is found in string: {1}", suffix, item);
                }
            }
            Console.ReadKey();
        }
    }
}
