using LibraryByAuthor; // importamos las bibliotecas necesarias
using System;   // aqui encontramos las clases fundamentales del lenguaje de c# 


class Program
{
    static void Main()
    {
        Library library = new Library();  // creamos la instancia  que nos representa la biblioteca


        // Agregamos los libros por Autor  

        library.AddBookByAuthor(new Book { Title = "Hábitos Atomicos", Author = "James Clear", ISBN = "23008574" }); // creamos una n instancia "", establecen prop. llamamos el met "", que agregue lib. a la biblioteca
        library.AddBookByAuthor(new Book { Title = "El poder del espejo", Author = "Louise Hay", ISBN = "23007814" });
        library.AddBookByAuthor(new Book { Title = "Todas mis heridas", Author = "Kathleen Glasgow", ISBN = "23001520" });
        library.AddBookByAuthor(new Book { Title = "Estoy Bien", Author = "Riuho Okawa", ISBN = "23001520" });
        library.AddBookByAuthor(new Book { Title = "Dejalo Ir ", Author = "John PurKiss  ", ISBN = "23001521" });
        library.AddBookByAuthor(new Book { Title = "Los 4 Acuerdos", Author = "Miguel Ruiz", ISBN = "23001522" });
        library.AddBookByAuthor(new Book { Title = "El Derecho a decir no", Author = "Walter Rizo", ISBN = "23001523" });
        library.AddBookByAuthor(new Book { Title = "Enamorate de Ti", Author = "Walter Rizo", ISBN = "23001522" });
        library.AddBookByAuthor(new Book { Title = "Como no escribir nuestra historia", Author = "Elisabeth Benabeth ", ISBN = "23001522" });
        library.AddBookByAuthor(new Book { Title = "Amar o Depender", Author = "Walter Rizo", ISBN = "23001524" });
        library.AddBookByAuthor(new Book { Title = "Manual Para no morir", Author = "Walter Rizo", ISBN = "23001526" });
        library.AddBookByAuthor(new Book { Title = "Escorpio", Author = "Mario Mendoza", ISBN = "23001527" });
        library.AddBookByAuthor(new Book { Title = "Amar o Depender", Author = "Walter Rizo", ISBN = "23001528" });
        library.AddBookByAuthor(new Book { Title = "La verdad de la mentira", Author = "Maria Reyes", ISBN = "23001530" });
        library.AddBookByAuthor(new Book { Title = "Saca Partido a tu vida", Author = "Alva Reyes", ISBN = "23001532" });

        
         // Agregar libros por título

         library.AddBookByTitle(new Book { Title = "Hábitos Atomicos", Author = "James Clear", ISBN = "23008574" });  // creamos una n instancia "", establecen prop. llamamos el met "", que agregue lib. a la biblioteca
        library.AddBookByTitle(new Book { Title = "El poder del espejo", Author = "Louise Hay", ISBN = "23007814" });
        library.AddBookByTitle(new Book { Title = "Todas mis heridas", Author = "Kathleen Glasgow", ISBN = "23001520" });
        library.AddBookByTitle(new Book { Title = "Estoy Bien", Author = "Riuho Okawa", ISBN = "23001520" });
        library.AddBookByTitle(new Book { Title = "Dejalo Ir ", Author = "John PurKiss  ", ISBN = "23001521" });
        library.AddBookByTitle(new Book { Title = "Los 4 Acuerdos", Author = "Miguel Ruiz", ISBN = "23001522" });
        library.AddBookByTitle(new Book { Title = "El Derecho a decir no", Author = "Walter Rizo", ISBN = "23001523" });
        library.AddBookByTitle(new Book { Title = "Enamorate de Ti", Author = "Walter Rizo", ISBN = "23001522" });
        library.AddBookByTitle(new Book { Title = "Como no escribir nuestra historia", Author = "Elisabeth Benabeth ", ISBN = "23001522" });
        library.AddBookByTitle(new Book { Title = "Amar o Depender", Author = "Walter Rizo", ISBN = "23001524" });
        library.AddBookByTitle(new Book { Title = "Manual Para no morir de Amor", Author = "Walter Rizo", ISBN = "23001526" });
        library.AddBookByTitle(new Book { Title = "Escorpio", Author = "Mario Mendoza", ISBN = "23001527" });
        library.AddBookByTitle(new Book { Title = "Desapegarse sin Anestecia", Author = "Walter Rizo", ISBN = "23001528" });
        library.AddBookByTitle(new Book { Title = "La verdad de la mentira", Author = "Maria Reyes", ISBN = "23001530" });
        library.AddBookByTitle(new Book { Title = "Saca Partido a tu vida", Author = "Alva Reyes", ISBN = "23001532" });

      

        // BUSCAR LIBROS POR AUTOR
        Console.WriteLine("Ingrese el autor a buscar:");  // solicita el autor que deseamos 
        string searchAuthor = Console.ReadLine();  // lee ent del user y se le asigna la var- sA, almacena nombre del autor   
        Console.WriteLine($"Libros por autor ({searchAuthor}):"); // imprime lo solicitado por el usuario
        var booksByAuthor = library.SearchByAuthor(searchAuthor); // se llama al met. SBA, en el obj LIb. Pasa el nombre de autor y realiza la busqueda que pertenece al autor solici.
        if (booksByAuthor.Count == 0) // con esto verificamos si no encontramos libros ,en bBA tenemos almacenado la can. de libros y "count nos devuelve el numero de elementos en lista.
        {
            Console.WriteLine("No se encontraron libros disponibles.");
        }
        else  // Cuando si se encuentran los libros, utilizamos este bloque 
        {
            foreach (var book in booksByAuthor) // Recorremos cada elemento de la lista, recorremos la variable book que nos permite acceder a las propiedades de c/l.
            {
                Console.WriteLine($"- {book.Title} de {book.Author} (ISBN: {book.ISBN})");
            }
        }

        // Buscar libros por título
        Console.WriteLine("Ingrese el título a buscar:");
        string searchTitle = Console.ReadLine();
        Console.WriteLine($"Libros por título ({searchTitle}):");
        var booksByTitle = library.SearchByTitle(searchTitle);
        if (booksByTitle.Count == 0)
        {
            Console.WriteLine("No se encontraron libros disponibles .");
        }
        else
        {
            foreach (var book in booksByTitle)
            {
                Console.WriteLine($"- {book.Title} by {book.Author} (ISBN: {book.ISBN})");
            }
        }
    }
}
