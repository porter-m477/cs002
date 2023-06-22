using System;

namespace AgendaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("==== Agenda App ====");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Eliminar contacto");
                Console.WriteLine("5. Modificar contacto");
                Console.WriteLine("6. Salir");
                Console.WriteLine("====================");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nombre del contacto:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el teléfono del contacto:");
                        string telefono = Console.ReadLine();
                        Console.WriteLine("Ingrese el correo del contacto:");
                        string correo = Console.ReadLine();

                        Contacto nuevoContacto = new Contacto()
                        {
                            Nombre = nombre,
                            Telefono = telefono,
                            Correo = correo
                        };

                        agenda.AgregarContacto(nuevoContacto);
                        break;

                    case "2":
                        agenda.MostrarContactos();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el nombre del contacto a buscar:");
                        string nombreBuscar = Console.ReadLine();
                        agenda.BuscarContacto(nombreBuscar);
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el nombre del contacto a eliminar:");
                        string nombreEliminar = Console.ReadLine();
                        agenda.EliminarContacto(nombreEliminar);
                        break;

                    case "5":
                        Console.WriteLine("Ingrese el nombre del contacto a modificar:");
                        string nombreModificar = Console.ReadLine();
                        agenda.ModificarContacto(nombreModificar);
                        break;

                    case "6":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}


