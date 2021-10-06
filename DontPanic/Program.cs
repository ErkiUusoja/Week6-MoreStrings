using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lasuet "don't panic"
            //läbiva suurtähega ja tagurpidi

            string dontpanic = "don't panic".ToUpper();
            for(int i = dontpanic.Length-1; i >= 0; i--)
            {
                Console.Write(dontpanic[i]);
            }

        }
    }
}
