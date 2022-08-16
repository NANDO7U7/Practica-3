using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Eligo la opcion {0}", option);
                    break;
                case 2:
                    Console.WriteLine("Eligo la opcion {0}", option);
                    break;
                case 3:
                    Console.WriteLine("Eligo la opcion {0}", option);
                    break;
                case 4:
                    Console.WriteLine("Eligo la opcion {0}", option);
                    break;
                case 5:
                    Console.WriteLine("Eligo la opcion {0}", option);
                    break;
                default:
                    Console.WriteLine("Esta opcion no existe");
                    break;
            }
        }
    }
}