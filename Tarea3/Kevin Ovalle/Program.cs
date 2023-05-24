using System;

namespace juego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de jugadores?");
            Console.WriteLine("1) Un jugador");
            Console.WriteLine("2) Dos jugadores");
            string opc = Console.ReadLine();
            Console.Clear();

            if (opc == "1")
            {
                string[] palabras = { "arena", "perro", "catapulta", "queso", "circunferencia", "hielo" };
                Random random = new Random();
                int random_num = random.Next(0, palabras.Length);
                char[] letras = palabras[random_num].ToCharArray();
                int word_length = letras.Length;
                int[] flagletras = new int[word_length];
                int intentos = 6;

                for (int i = 0; i < word_length; i++)
                {
                    flagletras[i] = 0;
                }

                bool game = true;
                do
                {
                    int letras_check = 0;
                    Console.WriteLine("Intentos restantes: " + intentos);

                    for (int h = 0; h < word_length; h++)
                    {
                        if (flagletras[h] == 0)
                        {
                            Console.Write(" _ ");
                        }
                        else
                        {
                            Console.Write(" " + letras[h] + " ");
                            letras_check++;
                        }
                    }

                    Console.WriteLine();

                    if (letras_check == word_length)
                    {
                        game = false;
                        Console.WriteLine("Has ganado el juego!");
                    }
                    else
                    {
                        Console.WriteLine("Ingresa una letra:");
                        char letr = Convert.ToChar(Console.ReadLine());
                        bool flagcheck = false;

                        for (int x = 0; x < word_length; x++)
                        {
                            if (letr == letras[x])
                            {
                                flagletras[x] = 1;
                                flagcheck = true;
                            }
                        }

                        if (flagcheck == false)
                        {
                            intentos--;
                        }

                        if (intentos == 0)
                        {
                            game = false;
                            Console.WriteLine("GAME OVER");
                        }
                    }
                } while (game);
            }
            else if (opc == "2")
            {
                Console.WriteLine("Jugador 1, ingresa una palabra sin que vea el Jugador 2:");
                string palabra = Console.ReadLine();
                char[] letras = palabra.ToCharArray();
                int word_length = letras.Length;
                int[] flagletras = new int[word_length];
                int intentos = 6;

                for (int i = 0; i < word_length; i++)
                {
                    flagletras[i] = 0;
                }

                bool game = true;
                do
                {
                    int letras_check = 0;
                    Console.WriteLine("Intentos restantes: " + intentos);

                    for (int h = 0; h < word_length; h++)
                    {
                        if (flagletras[h] == 0)
                        {
                            Console.Write(" _ ");
                        }
                        else
                        {
                            Console.Write(" " + letras[h] + " ");
                            letras_check++;
                        }
                    }

                    Console.WriteLine();

                    if (letras_check == word_length)
                    {
                        game = false;
                        Console.WriteLine("Has ganado el juego!");
                    }
                    else
                    {
                        Console.WriteLine("Ingresa una letra:");
                        char letr = Convert.ToChar(Console.ReadLine());
                        bool flagcheck = false;

                        for (int x = 0; x < word_length; x++)
                        {
                            if (letr == letras[x])
                            {
                                flagletras[x] = 1;
                                flagcheck = true;
                            }
                        }

                        if (flagcheck == false)
                        {
                            intentos--;
                        }

                        if (intentos == 0)
                        {
                            game = false;
                            Console.WriteLine("Has ganado Jugador 1");
                        }
                    }
                } while (game);
            }
        }
    }
}
