using LibroSpace;

public class Biblioteca
{
    private List<Libro> libros;

    public Biblioteca()
    {
        libros = new List<Libro>(){};
    }
    public void InsertarLibro(Libro libro)
    {
        libros.Add(libro);
    }
    public List<Libro> BuscarAutor(string autor)
    {
        return  libros.Where(x => x.Autor.Contains(autor)).ToList();
    }
    public List<Libro> BuscarTitulo(string titulo)
    {
        return  libros.Where(x => x.Titulo.Contains(titulo)).ToList();
    }
}
