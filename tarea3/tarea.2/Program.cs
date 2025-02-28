using System;

namespace tarea._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumarConManejoDeErrores();
        }

        static void SumarConManejoDeErrores()
        {
            try
            {
                Console.Write("Ingresa el primer número: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int suma = num1 + num2;
                Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debes ingresar un número válido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número ingresado es demasiado grande.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operación finalizada.");
            }
        }
    }
}
