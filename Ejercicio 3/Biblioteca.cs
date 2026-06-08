class Biblioteca
{
    private string nombre;
    private string direccion;

    private Libro[] libros;

    public Biblioteca(string nombre, string direccion)
    {
        this.nombre = nombre;
        this.direccion = direccion;

        libros = new Libro[4];
    }

    public void AgregarLibro(Libro libro)
    {
        for (int i = 0; i < libros.Length; i++)
        {
            if (libros[i] == null)
            {
                libros[i] = libro;
                return;
            }
        }

        Console.WriteLine("No se pueden agregar más libros");
    }

    public Libro LibroMasLargo()
    {
        Libro mayor = libros[0];

        for (int i = 1; i < libros.Length; i++)
        {
            if (libros[i] != null &&
                libros[i].GetCantidadPaginas() >
                mayor.GetCantidadPaginas())
            {
                mayor = libros[i];
            }
        }

        return mayor;
    }
}