
using System;

class Program
{
    static void Main()
    {
        // a) Crear una biblioteca
        Biblioteca biblioteca =
            new Biblioteca(
                "Biblioteca Municipal",
                "San Martín 123");

        // b) Crear 5 libros
        Libro libro1 =
            new Libro(
                "C# Básico",
                "Juan Pérez",
                250,
                2020);

        Libro libro2 =
            new Libro(
                "POO en C#",
                "Ana Gómez",
                350,
                2021);

        Libro libro3 =
            new Libro(
                "Bases de Datos",
                "Carlos Ruiz",
                500,
                2019);

        Libro libro4 =
            new Libro(
                "Redes",
                "Laura Díaz",
                280,
                2022);

        Libro libro5 =
            new Libro(
                "Algoritmos",
                "Pedro López",
                420,
                2018);

        // c) Agregar libros
        biblioteca.AgregarLibro(libro1);
        biblioteca.AgregarLibro(libro2);
        biblioteca.AgregarLibro(libro3);
        biblioteca.AgregarLibro(libro4);

        // d) Intentar agregar el quinto
        biblioteca.AgregarLibro(libro5);

        // e) Mostrar el libro con más páginas
        Libro mayor = biblioteca.LibroMasLargo();

        Console.WriteLine("\nLIBRO MÁS LARGO");

        Console.WriteLine(
            $"Título: {mayor.GetTitulo()}");

        Console.WriteLine(
            $"Autor: {mayor.GetAutor()}");

        Console.WriteLine(
            $"Páginas: {mayor.GetCantidadPaginas()}");

        Console.WriteLine(
            $"Año: {mayor.GetAnioPublicacion()}");
    }
}