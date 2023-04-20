using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adivine el numero entre 0 y 20
            int theNumber = new Random().Next(20);
            bool keepGoing = true;

            // Print instrucciones y reglas del juego
            Console.WriteLine("Juega 'Adivina el numero'!");
            Console.WriteLine("Piensa en un numero entre 0 y 20.");
            Console.WriteLine("Entra tu numero ahora, o -1 para rendirte.");

            // Tener en cuenta las veces que intenta el jugador antes de ganar
            int guessNum = 0;
            int guessCount = 0;

            // Usando un do-while loop porque queremos que corra por lo menos una vez
            do
            {
                // Preguntar por un numero
                Console.WriteLine("Cual es tu numero?");
                string theGuess = Console.ReadLine();

                // Usando el TryParse method para convertir el input en un numero
                bool result = Int32.TryParse(theGuess, out guessNum);

                // Que pasa si entra algo diferente a un numero
                if (!result)
                {
                    Console.WriteLine("Hmmm, solo se aceptan numeros. Intenta de nuevo.");
                }
                else
                {
                    // Si entran un -1 entonces quieren salir del juego
                    if (guessNum == -1)
                    {
                        Console.WriteLine($"Te rendiste. la respuesta correcta es {theNumber}");
                        keepGoing = false;
                    }
                    else
                    {
                        // Incrementar el contador de intentos
                        guessCount++;

                        // Si aciertan, decirle al jugador su numero de intentos y salir
                        if (guessNum == theNumber)
                        {
                            Console.WriteLine($"Lo lograste en {guessCount} intentos!!");
                            keepGoing = false;
                        }
                        else
                        {
                            // Feedback: decirles si esta arriba o abajo del numero ganador
                            Console.WriteLine("No, el numero es mas {0}.", guessNum < theNumber ? "alto" : "bajo");
                        }
                    }
                }
            } while (keepGoing);

        }
    }
}
