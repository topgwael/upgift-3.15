using System;
namespace Uppgift_3_15
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mång timmer vill du hyra en bil?");
            string x = Console.ReadLine();
            int y = int.Parse(x);
            int z = y * 80;
            if (y >= 12)
            {
                Console.WriteLine("Du kan inte hyra bilen så länge.");
            }
            else
            {
                Console.WriteLine("Det kommer kosta " + z + " kronor");
            }
        }
    }
}