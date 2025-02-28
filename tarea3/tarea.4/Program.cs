using System;

namespace tarea._4
{
    internal class Program
    {
        static int puntajeRecord = 0;
        static string jugadorRecord = "Nadie";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingresa el nombre del jugador (o escribe 'salir' para terminar): ");
                string jugador = Console.ReadLine();

                if (jugador.ToLower() == "salir")
                    break;

                Console.Write("Ingresa el puntaje obtenido: ");
                if (int.TryParse(Console.ReadLine(), out int puntaje))
                {
                    RegistrarPuntaje(puntaje, jugador);
                }
                else
                {
                    Console.WriteLine("Error: Ingresa un número válido para el puntaje.\n");
                }
            }
        }

        static void RegistrarPuntaje(int puntaje, string jugador)
        {
            if (puntaje > puntajeRecord)
            {
                puntajeRecord = puntaje;
                jugadorRecord = jugador;
                Console.WriteLine("\nLa nueva puntuación más alta es " + puntaje);
                Console.WriteLine("La puntuación más alta fue lograda por " + jugadorRecord + "\n");
            }
            else
            {
                Console.WriteLine("\nLa puntuación más alta de " + puntajeRecord + " no se ha podido superar, y aún está en manos de " + jugadorRecord + "\n");
            }
        }
    }
}
