class Libro
{
    private string titulo;
    private string autor;
    private int cantidadPaginas;
    private int anioPublicacion;

    // Constructor
    public Libro(string titulo, string autor, int cantidadPaginas, int anioPublicacion)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.cantidadPaginas = cantidadPaginas;
        this.anioPublicacion = anioPublicacion;
    }

    // Getters
    public string GetTitulo()
    {
        return titulo;
    }

    public string GetAutor()
    {
        return autor;
    }

    public int GetCantidadPaginas()
    {
        return cantidadPaginas;
    }

    public int GetAnioPublicacion()
    {
        return anioPublicacion;
    }

    // Setters
    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public void SetAutor(string autor)
    {
        this.autor = autor;
    }

    public void SetCantidadPaginas(int cantidadPaginas)
    {
        this.cantidadPaginas = cantidadPaginas;
    }

    public void SetAnioPublicacion(int anioPublicacion)
    {
        this.anioPublicacion = anioPublicacion;
    }
}