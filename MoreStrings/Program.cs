using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale
            //initsiaalid lõpevad punktiga
            //--> Harry Potter --> H. P.

            Console.WriteLine("Sisesta eesnimi:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string LastName = Console.ReadLine();

            Console.WriteLine($"Tere{FirstName[0]}. {LastName[0]}.!");



        }
    }
}
