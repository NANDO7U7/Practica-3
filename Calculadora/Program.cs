using System;

namespace Calculadora
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double resultado = double.NaN;

            switch (op)
            {
                case "a":
                    resultado = num1 + num2;
                    break;
                case "s":
                    resultado = num1 - num2;
                    break;
                case "m":
                    resultado = num1 * num2;
                    break;
                case "d":

                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    break;

                default:
                    break;
            }
            return resultado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                string numInput1 = "";
                string numInput2 = "";
                double result = 0;


                Console.Write("Escriba un número y luego presione Entrar: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Esta no es una entrada válida. Por favor ingrese un valor entero: ");
                    numInput1 = Console.ReadLine();
                }


                Console.Write("Escriba otro número y luego presione Entrar: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Esta no es una entrada válida. Por favor ingrese un valor entero: ");
                    numInput2 = Console.ReadLine();
                }


                Console.WriteLine("Elija un operador de la siguiente lista:");
                Console.WriteLine("\ta - Suma");
                Console.WriteLine("\ts - Resta");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("tu opcion? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Esta operación dará como resultado un error matemático..\n");
                    }
                    else Console.WriteLine("Tu resultado: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("¡Oh, no! Se produjo una excepción al intentar hacer los cálculos.\n - Detalles: " + e.Message);
                }

                Console.WriteLine("------------------------\n");


                Console.Write("Presione 'n' y Enter para cerrar la aplicación, o presione cualquier otra tecla y Enter para continuar: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}