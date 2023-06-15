using System;
using System.Collections.Generic;

namespace AgendaApp
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }

    public class Agenda
    {
        private List<Contacto> contactos;

        public Agenda()
        {
            contactos = new List<Contacto>();
        }

        public void AgregarContacto(Contacto contacto)
        {
            contactos.Add(contacto);
            Console.WriteLine("Contacto agregado exitosamente.");
        }

        public void MostrarContactos()
        {
            if (contactos.Count == 0)
            {
                Console.WriteLine("La agenda no tiene contactos.");
            }
            else
            {
                Console.WriteLine("Contactos en la agenda:");
                foreach (var contacto in contactos)
                {
                    Console.WriteLine($"Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}, Correo: {contacto.Correo}");
                }
            }
        }

        public void BuscarContacto(string nombre)
        {
            bool encontrado = false;
            foreach (var contacto in contactos)
            {
                if (contacto.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Contacto encontrado - Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}, Correo: {contacto.Correo}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró el contacto en la agenda.");
            }
        }

        public void EliminarContacto(string nombre)
        {
            Contacto contactoEncontrado = null;
            foreach (var contacto in contactos)
            {
                if (contacto.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    contactoEncontrado = contacto;
                    break;
                }
            }

            if (contactoEncontrado != null)
            {
                contactos.Remove(contactoEncontrado);
                Console.WriteLine("Contacto eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("No se encontró el contacto en la agenda.");
            }
        }

        public void ModificarContacto(string nombre)
        {
            Contacto contactoEncontrado = null;
            foreach (var contacto in contactos)
            {
                if (contacto.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    contactoEncontrado = contacto;
                    break;
                }
            }

            if (contactoEncontrado != null)
            {
                Console.WriteLine("Ingrese el nuevo teléfono del contacto:");
                string nuevoTelefono = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo correo del contacto:");
                string nuevoCorreo = Console.ReadLine();

                contactoEncontrado.Telefono = nuevoTelefono;
                contactoEncontrado.Correo = nuevoCorreo;

                Console.WriteLine("Contacto modificado exitosamente.");
            }
            else
            {
                Console.WriteLine("No se encontró el contacto en la agenda.");
            }
        }
    }
}
