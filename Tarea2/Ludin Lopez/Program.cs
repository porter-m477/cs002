internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        int salir = 0;




        while (salir == 0)
        {
            Console.WriteLine("seleccione que operacion o accion desea realizar");
            Console.WriteLine("1.Sumar  2.Restar    3.Multiplicar   4.dividir  5.Salir");
            opcion = int.Parse(Console.ReadLine());


            if (opcion == 1)
            {
                sumar ();
            }
            else if (opcion == 2)
            {
                restar ();
            }
            else if (opcion == 3)
            {
                multiplicar ();
            }
            else if (opcion == 4)
            {
                dividir ();
            }
            else if (opcion == 5)
            {
                salir = 1;
            }
            else
            {
                Console.WriteLine("No ha seleccionado ninguna de las opciones propuestas");
            }

        };


        static void sumar (){
            double[] intro = entrada();

            double result = intro[0] + intro[1];
            Console.WriteLine("El resultado de la suma es: " + result );
        }

        static void restar (){
            double[] intro = entrada();

            double result = intro[0] - intro[1];
            Console.WriteLine("El resultado de la resta es: " + result );
        }

        static void multiplicar (){
            double[] intro = entrada();

            double result = intro[0] * intro[1];
            Console.WriteLine("El resultado de la multiplicacion es: " + result );
        }

        static void dividir (){
            double[] intro = entrada();

            double result = intro[0] / intro[1];
            Console.WriteLine("El resultado de la divicion es: " + result );
        }

        static double[] entrada (){
            double[] intro = {0,0};
            Console.WriteLine("Ingrese el primer numero:");
            intro[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo numero:");
            intro[1] = double.Parse(Console.ReadLine());
            return intro;
        }

    }
}