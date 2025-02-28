using System;

namespace tarea._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Ingresa el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Suma: {calc.Sumar(num1, num2)}");
            Console.WriteLine($"Resta: {calc.Restar(num1, num2)}");
            Console.WriteLine($"Multiplicación: {calc.Multiplicar(num1, num2)}");
            Console.WriteLine($"División: {calc.Dividir(num1, num2)}");
        }
    }

    class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return 0;
            }
            return a / b;
        }
    }
}
