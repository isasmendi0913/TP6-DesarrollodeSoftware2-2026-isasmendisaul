using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Estudiante
{
    // Atributos privados de la clase Estudiante
    private string nombre;
    private string apellido;
    private int legajo;
    private double notaFinal;
    // Constructor para inicializar los atributos de la clase
    public Estudiante(string nombre, string apellido,
                      int legajo, double notaFinal)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.legajo = legajo;
        this.notaFinal = notaFinal;
    }

    //metodos getters para acceder a los atributos privados de la clase
    public string GetNombre()
    {
        return nombre;
    }

    public string GetApellido()
    {
        return apellido;
    }

    public int GetLegajo()
    {
        return legajo;
    }

    public double GetNotaFinal()
    {
        return notaFinal;
    }

    // metodos setters para modificar los atributos privados de la clase
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetApellido(string apellido)
    {
        this.apellido = apellido;
    }

    public void SetLegajo(int legajo)
    {
        this.legajo = legajo;
    }

    public void SetNotaFinal(double notaFinal)
    {
        this.notaFinal = notaFinal;
    }
}