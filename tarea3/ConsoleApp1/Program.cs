namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                CalcularIngresos();
            }

            static void CalcularIngresos()
            {
                Console.Write("Ingresa tu nombre: ");
                string usuario = Console.ReadLine();

                decimal[] ingresos = new decimal[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Ingresa tus ingresos del mes {i + 1}: ");
                    ingresos[i] = Convert.ToDecimal(Console.ReadLine());
                }

                decimal suma = ingresos[0] + ingresos[1] + ingresos[2];
                decimal promedio = suma / 3;

                Console.WriteLine($"Hola {usuario}, en total ganaste {suma} y promediaste {promedio}");
            }
        }

    }
    
