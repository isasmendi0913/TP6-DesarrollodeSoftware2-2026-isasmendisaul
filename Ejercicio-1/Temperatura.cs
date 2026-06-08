using System;
class Temperatura
{
    // es un atributo de temperatura
    public float gradosCelsius;

// es un constructor que recibe la temperatura en grados Celsius
public Temperatura(float gradosCelsius)
{
    this.gradosCelsius = gradosCelsius;
}

// es un getter para obtener la temperatura en grados Celsius
public float GetGradosCelsius()
{
    return gradosCelsius;
}

// es un setter para establecer la temperatura en grados Celsius
public void SetGradosCelsius(float gradosCelsius)
{
    this.gradosCelsius = gradosCelsius;
}

// Retorna true si la temperatura es menor a 0
public bool EsNegativa()
{
    return gradosCelsius < 0;
}

// Convierte a Fahrenheit
public float ConvertirAFahrenheit()
{
    return (gradosCelsius * 9 / 5) + 32;
}

// Compara con otra temperatura
    public bool EsMayorA(float temperatura)
    {
    return gradosCelsius > temperatura;
    }
}