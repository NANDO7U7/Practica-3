using System;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero a procesar: ");
            int multiplo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el limite");
            int limite = int.Parse(Console.ReadLine());

            for (int i = 0; i <= limite; i++)
            {
                if (i % multiplo == 0)
                {


                    Console.WriteLine(i + " ");
                }

            }
        }
    }
}