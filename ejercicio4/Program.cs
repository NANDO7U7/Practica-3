using System;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Ingrese un numero entero (con 0 se finaliza): ");
                num = int.Parse(Console.ReadLine());

                if (num >= 100)
                {
                    Console.WriteLine("Tiene 3 digitos.");
                }
                else if (num >= 10)
                {
                    Console.WriteLine("Tiene 2 digitos.");
                }
                else
                {
                    Console.WriteLine("Tiene 1 digitos.");

                }
            } while (num != 0);
        }

    }
}
