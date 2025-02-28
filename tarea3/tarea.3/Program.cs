using System;

namespace tarea._3
{
    internal class Program
    {
        static string usuarioRegistrado = "";
        static string contraseñaRegistrada = "";

        static void Main(string[] args)
        {
            RegistrarUsuario();
            IniciarSesion();
        }

        static void RegistrarUsuario()
        {
            Console.WriteLine("Registro de usuario");
            Console.Write("Ingresa un nombre de usuario: ");
            usuarioRegistrado = Console.ReadLine();

            Console.Write("Ingresa una contraseña: ");
            contraseñaRegistrada = Console.ReadLine();

            Console.WriteLine("Registro exitoso. Ahora inicia sesión.\n");
        }

        static void IniciarSesion()
        {
            Console.WriteLine("Inicio de sesión");
            Console.Write("Usuario: ");
            string usuarioIngresado = Console.ReadLine();

            Console.Write("Contraseña: ");
            string contraseñaIngresada = Console.ReadLine();

            if (usuarioIngresado == usuarioRegistrado && contraseñaIngresada == contraseñaRegistrada)
            {
                Console.WriteLine("Inicio de sesión exitoso. Bienvenido, " + usuarioRegistrado + "!");
            }
            else
            {
                Console.WriteLine("Error: Usuario o contraseña incorrectos.");
            }
        }
    }
}
