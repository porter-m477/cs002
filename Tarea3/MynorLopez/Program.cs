using System;

namespace AhorcadoJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            int correcta = 0;
            string palabra = ElegirPalabra();
            char[] palabraLetras = palabra.ToCharArray();
            char[] palabraConGuiones = GenerarGuiones(palabra);
            string cadenaIngresada = " ";
            char letraIngresada = ' ';
            bool gano = false;

            while (gano == false)
            {
                int soloUnaLetra = 0;
                while(soloUnaLetra == 0)
                {
                    EscribirPalabraEspacios(palabraConGuiones);
                    Console.WriteLine();
                    Console.Write("Ingresa una letra: ");
                    cadenaIngresada = Console.ReadLine();
                    if(CompruebaSeaUnaLetra(cadenaIngresada))
                    {
                        letraIngresada = Convert.ToChar(cadenaIngresada);
                        soloUnaLetra++;
                    }else{
                        Console.Clear();
                        Console.Write("Debes ingresar solo una letra");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                for(int l = 0; l < palabraConGuiones.Length; l++)
                {
                    if(letraIngresada  == palabraLetras[l])
                    {
                        palabraConGuiones[l] = letraIngresada;
                        correcta++;
                    }
                }
                if(correcta == palabraLetras.Length)
                {
                    gano = true;
                }
                intentos++;
                Console.Clear();
            }
            EscribirFinDeJuego(palabra, intentos, gano);
        }

        static string ElegirPalabra()
        {
            Random random = new Random();
            int n = random.Next(0,4);
            string[] palabras = {"guatemala", "bicicleta", "bandera", "videojuego", "computadora"};
            string palabraSeleccionada = palabras[n];
            return palabraSeleccionada;
        }

        static char[] GenerarGuiones(string palabra)
        {
            char[] palabraAdivinar = palabra.ToCharArray();
            for(int i = 0; i < palabra.Length; i++){
                palabraAdivinar[i] = '_';
            }
            return palabraAdivinar;
        }

        static void EscribirPalabraEspacios(char[] palabraAdivinar)
        {
            Console.WriteLine();
            for(int j = 0; j < palabraAdivinar.Length; j++)
            {
                Console.Write(palabraAdivinar[j] +  " ");
            }
            Console.WriteLine();
        }

        static bool CompruebaSeaUnaLetra(string letra)
        {
            bool soloUnaLetra = false;
            if(letra.Length == 1)
            {
                soloUnaLetra = true;
            }
            return soloUnaLetra;
        }

        static void EscribirFinDeJuego(string palabra, int intentos, bool gano)
        {
            if(gano == true)
            {
                Console.WriteLine();
                Console.WriteLine("Felicidades ganaste ... !!");
                Console.WriteLine($"La palabra fue: {palabra}");
                Console.WriteLine($"Intentos: {intentos}");
            }
        }
    }
}