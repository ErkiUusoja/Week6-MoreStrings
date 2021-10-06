using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'n' tähte on
            //lauses "don't panic"

            string dontpanic = "don't panic".ToLower();

            int counter = 0;

            for(int i = 0; i < dontpanic.Length; i++)
            {
                if (dontpanic[i] == 'n')
                {
                    counter++;
                }
            }
            Console.WriteLine($"lauses {dontpanic} on {counter} 'n' tähte.");


        }
    }
}
