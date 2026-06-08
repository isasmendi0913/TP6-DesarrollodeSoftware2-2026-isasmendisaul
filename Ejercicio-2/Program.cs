using System;
class Program
{
    static void Main()
    {

        // Crear un triángulo escaleno (lados diferentes)
        Triangulo t = new Triangulo(7, 5, 9, 7, 8);

        Console.WriteLine($"Área: {t.CalcularArea()}");
        Console.WriteLine($"los lados son: {t.GetLado1()}, {t.GetLado2()}, {t.GetLado3()}");
        Console.WriteLine($"Perímetro: {t.CalcularPerimetro()}");
        Console.WriteLine($"¿Equilátero? {t.EsEquilatero()}");

        // Modificar los lados para convertirlo en equilátero (usando setters)
        t.SetLado1(7);
        t.SetLado2(7);
        t.SetLado3(7);

        Console.WriteLine("\nDespués de modificar los lados:");
        Console.WriteLine($"los lados son: {t.GetLado1()}, {t.GetLado2()}, {t.GetLado3()}");
        Console.WriteLine($"¿Equilátero? {t.EsEquilatero()}");
        Console.WriteLine($"Nuevo perímetro: {t.CalcularPerimetro()}");
        Console.WriteLine("Os lados formam um triângulo.");
    }
}
    