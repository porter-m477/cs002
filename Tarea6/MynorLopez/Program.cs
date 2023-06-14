using LibroSpace;
class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        biblioteca.InsertarLibro(new Libro() { Titulo = "Principito", Autor = "Diego Estrada"});
        biblioteca.InsertarLibro(new Libro() { Titulo = "El extranjero", Autor = "Albert Camus"});
        biblioteca.InsertarLibro(new Libro() { Titulo = "Poema de Gilgamesh", Autor = "Anonimo"});
        biblioteca.InsertarLibro(new Libro() { Titulo = "El secreto", Autor = "Mario Lopez"});
        biblioteca.InsertarLibro(new Libro() { Titulo = "Baldor", Autor = "Juan Manuel"});
        biblioteca.InsertarLibro(new Libro() { Titulo = "Las mil y una noches", Autor = "Anonimo"});
        biblioteca.InsertarLibro(new Libro() { Titulo = "Orgullo y prejuicio", Autor = "Jane Austen"});

        Console.WriteLine("Buscar por autor(1) o titulo(2)");
        int opcion = Convert.ToInt32(Console.ReadLine());
        switch(opcion)
        {
            case 1:
                Console.WriteLine("Buscar por autor: ");
                string buscarAutor = Console.ReadLine();

                var miBusqueda = biblioteca.BuscarAutor(buscarAutor);
                if(!miBusqueda.Any()){
                    Console.WriteLine("No hay libros con ese autor");
                }
                else{
                    foreach(var busqueda in miBusqueda)
                    {
                        Console.WriteLine($"Titulo: {busqueda.Titulo} Autor: {busqueda.Autor}");
                    }
                }
                break;
            case 2:
                Console.WriteLine("Buscar por titulo: ");
                string buscarTitulo = Console.ReadLine();

                var miBusqueda2 = biblioteca.BuscarTitulo(buscarTitulo);
                if(!miBusqueda2.Any()){
                    Console.WriteLine("No hay libros con ese titulo");
                }
                else{
                    foreach(var busqueda in miBusqueda2)
                    {
                        Console.WriteLine($"Titulo: {busqueda.Titulo} Autor: {busqueda.Autor}");
                    }
                }
                break;
            default:
                Console.WriteLine("No existe opcion.");
                break;
        }
    }
}