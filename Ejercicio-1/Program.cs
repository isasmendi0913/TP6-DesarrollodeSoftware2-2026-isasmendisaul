using System;

class Program_Temperatura
{
    static void Main()
    {
        // a) Crear un objeto Temperatura con valor 25
        Temperatura temperatura = new Temperatura(25);

        // b) Mostrar si es negativa
        Console.WriteLine($"¿La temperatura es negativa? {temperatura.EsNegativa()}"
        );

        // c) Mostrar conversión a Fahrenheit
        Console.WriteLine(
            $"Temperatura en Fahrenheit: {temperatura.ConvertirAFahrenheit()}"
        );

        // d) Mostrar si es mayor a 18
        Console.WriteLine(
            $"¿Es mayor a 18 grados? {temperatura.EsMayorA(18)}"
        );
    }
}
