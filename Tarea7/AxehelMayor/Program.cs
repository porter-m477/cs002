using System;
using System.Collections.Generic;

public class Program
{
    private static List<Contacto> contactos = new List<Contacto>();

    public static void Main(string[] args)  // Punto de entrada del programa
    {
        while  (true) // Ceamos un ciclo infinito, para no estar reiniciando el programa cada vez
        {
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Eliminar contacto");
            Console.WriteLine("3. Editar contacto");
            Console.WriteLine("4. Mostrar contactos");
            Console.WriteLine("5. Salir");

            Console.WriteLine("Seleccione una opción: "); // solicita al usuario que seleccione una opcion
            string opcion = Console.ReadLine(); // almacenamos la entrada del usuario en la var "opcio

            switch (opcion.ToLower())  
            { // switch realizamos diferentes acciones segun el valor de la opcion
                case "1":
                    AgregarContacto(); // llama a la funcion que nos permite agregar contactos
                    break;
                case "2":
                    EliminarContacto();
                    break;
                case "3":
                    EditarContacto();
                    break;
                case "4":
                    MostrarContactos();
                    break;
                case "5":
                    return; // se usa para salir de la funcion del main y finaliar el programa 
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente."); // si no se coincide con ninguna de las opciones 
                    break;
            }
        }
    }

    public static void AgregarContacto() // Definimos la funcion 
    {
        Console.Write("Ingrese el nombre del contacto: ");   // muestra el mensaje en la consola
        string nombre = Console.ReadLine();  // espera a que el usuario ingrese el nombre y se almacena en la var. "nombre"

        Console.Write("Ingrese el número de teléfono del contacto: "); // repite los pasos 
        string telefono = Console.ReadLine();

        Contacto contacto = new Contacto // se crea un objecto "Contacto"
        {
            Nombre = nombre, // se le asigna el valor " nombre" y utilizan las prop. ingresadas
            Telefono = telefono // se repite
        };

        contactos.Add(contacto); // usamos el metodo "add" para agregarlo a la lista 
        Console.WriteLine("Contacto agregado exitosamente."); // imprime en la consola
    }

    public static void EliminarContacto() // Definimos la funcion 
    {
        Console.Write("Ingrese el nombre del contacto que desea eliminar: "); // muestra el smj 
        string nombre = Console.ReadLine();

        Contacto contacto = contactos.Find(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)); // 

        if (contacto != null) // verifica si se encontro un contacto, contacto no es igual a null 
        {
            contactos.Remove(contacto);  // si se encuentra uno con el nombre seleccionado, se elimina
            Console.WriteLine("Contacto eliminado exitosamente."); // imprime en la consola 
        }
        else
        {
            Console.WriteLine("No se encontró ningún contacto con ese nombre.");
        }
    }

    public static void EditarContacto()  // Definimos la funcion 
    {
        Console.Write("Ingrese el nombre del contacto que desea editar: ");
        string nombre = Console.ReadLine(); // el nombre se almacena en esta variable "nombre"

        Contacto contacto = contactos.Find(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)); // se busca contacto cuyo noombre sea = al ingresado.

        if (contacto != null) // verifica si la variable no es nula 
        {
            Console.Write("Ingrese el nuevo nombre del contacto: ");
            contacto.Nombre = Console.ReadLine(); // se asigna el valor ingresado a la propiedad Nombre del objeto contacto.

            Console.Write("Ingrese el nuevo número de teléfono del contacto: ");
            contacto.Telefono = Console.ReadLine();

            Console.WriteLine("Contacto editado exitosamente.");
        }
        else
        {
            Console.WriteLine("No se encontró ningún contacto con ese nombre."); // se imprime cuando la variable "contacto" sea nula
        }
    }

    public static void MostrarContactos() // Se define la funcion 
    {
        if (contactos.Count == 0) // verifica si la cantidad de elementos en lista es = 0
        {
            Console.WriteLine("No se han agregado contactos.");  // se usa si se cumple la funcion
        }
        else
        {
            Console.WriteLine("Contactos:");

            foreach (Contacto contacto in contactos) // lo usamos para recorrer cada element de lista
            {
                Console.WriteLine($"Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}"); // incluimos las 2 propiedades del objeto contacto
            }
        }
    }
}
