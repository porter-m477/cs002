using System;

namespace PiedraPapelTijeras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al juego de Piedra, Papel o Tijeras!");
            Console.WriteLine("Para jugar, ingresa 'piedra', 'papel' o 'tijeras' y presiona Enter.");
            Console.WriteLine("Presiona cualquier tecla para comenzar el juego.");
            Console.ReadKey();

            bool jugarDeNuevo = true;
            while (jugarDeNuevo)
            {
                Console.Clear();

                Console.Write("Ingresa tu elección: ");
                string eleccionJugador = Console.ReadLine().ToLower();

                // La computadora elige al azar entre piedra, papel o tijeras
                Random rnd = new Random();
                int eleccionComputadora = rnd.Next(1, 4);
                string eleccionComputadoraTexto = "";
                switch (eleccionComputadora)
                {
                    case 1:
                        eleccionComputadoraTexto = "piedra";
                        break;
                    case 2:
                        eleccionComputadoraTexto = "papel";
                        break;
                    case 3:
                        eleccionComputadoraTexto = "tijeras";
                        break;
                }

                Console.WriteLine("La computadora eligió: " + eleccionComputadoraTexto);

                // Determina el resultado del juego
                if (eleccionJugador == eleccionComputadoraTexto)
                {
                    Console.WriteLine("Empate.");
                }
                else if (eleccionJugador == "piedra" && eleccionComputadoraTexto == "tijeras" || eleccionJugador == "papel" && eleccionComputadoraTexto == "piedra" || eleccionJugador == "tijeras" && eleccionComputadoraTexto == "papel")
                {
                    Console.WriteLine("¡Ganaste!");
                }
                else
                {
                    Console.WriteLine("Lo siento, perdiste.");
                }

                Console.Write("¿Jugar de nuevo? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                jugarDeNuevo = respuesta == "s";
            }

            Console.WriteLine("¡Gracias por jugar!");
            Console.ReadKey();
        }
    }
}
