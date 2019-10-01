using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv 5 heltal");
            int[] Tal = new int[5];
            for (int i = 0; i < Tal.GetLength(0); i++)
                {
                string m = Console.ReadLine();
                int.TryParse(m, out int a);
                Tal[i] = a;                
            }
            
            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(Tal[i]);
            }



        }
        
    }
}
