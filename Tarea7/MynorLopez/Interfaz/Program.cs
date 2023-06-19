
using System;

class Program
{
    private static Agenda agenda = new Agenda();
    static void Main(string[] args)
   {
        while(true)
        {   
            Console.WriteLine("///  CONTACTO ///");
            Console.WriteLine("1. Nuevo ");
            Console.WriteLine("2. Eliminar ");
            Console.WriteLine("3. Ver todos ");
            Console.WriteLine("4. Buscar");
            Console.WriteLine("5. Salir");
            Console.WriteLine("=====================================");
            Console.WriteLine("Opción: "); 
            string opcion = Console.ReadLine(); 
            Console.WriteLine("=====================================");
            switch (opcion.ToLower())  
            { 
                case "1":
                    NuevoContacto(); 
                    break;
                case "2":
                    Eliminar();
                    break;
                case "3":
                    MostrarContactos();
                    break;
                case "4":
                    BuscarContacto();
                    break;
                case "5":
                    return; 
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente."); 
                    break;
            }
        }
    }

    public static void NuevoContacto() 
    {
        Console.Write("Nombre nuevo contacto: ");  
        string nombre = Console.ReadLine();  
        Console.Write("Teléfono del contacto: "); 
        string telefono = Console.ReadLine();
        agenda.InsertarContacto(new Contacto(){  Nombre = nombre,  Telefono = telefono  });
        Console.WriteLine("El contacto se agrego"); 
        Console.ReadKey();
        Console.Clear();
    }

    public static void Eliminar() 
    {
        Console.Write("Telefono a eliminar: "); 
        string telefono = Console.ReadLine();

        var mensaje = agenda.EliminarContacto(telefono);
        Console.WriteLine(mensaje);
        
        Console.ReadKey();
        Console.Clear();
    }

    public static void MostrarContactos() 
    {
        var todos = agenda.VerContactos();
        if (!todos.Any()) 
        {
            Console.WriteLine("No hay contactos.");
        }
        else
        {
            foreach (var conta in todos) 
            {
                Console.WriteLine($"Nombre: {conta.Nombre}, Teléfono: {conta.Telefono}"); 
            }
            Console.ReadKey();
            Console.Clear();
        }
    }

    public static void BuscarContacto()
    {
        Console.WriteLine("Nombre de contacto a buscar: ");
        string elContacto = Console.ReadLine();
        var busqueda = agenda.BuscarNombre(elContacto);

        foreach(var contac in busqueda)
        {
            Console.WriteLine($"Nombre: {contac.Nombre} Numero: {contac.Telefono}");
        }
        Console.ReadKey();
        Console.Clear();
    }
}