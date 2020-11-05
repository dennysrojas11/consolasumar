using System;

namespace ConAppSumar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ud ingreso un número de parámetros {0}", args.Length);
            if (args.Length != 2)
            {
                Console.WriteLine("Debe ingresar únicamente dos (2) valores");
            }
            else
            {
                int numero1 = int.Parse(args[0]);
                int numero2 = int.Parse(args[1]);
                int resultadoSuma = numero1 + numero2;
                Console.WriteLine("La suma es: {0}", resultadoSuma);
            }
        }
    }
}