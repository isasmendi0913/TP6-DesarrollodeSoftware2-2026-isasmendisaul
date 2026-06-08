using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Curso
{   //atributos de la clase Curso
    private string nombreCurso;
    private string profesor;
    // arreglo de estudiantes para almacenar los estudiantes del curso
    private Estudiante[] estudiantes;
    // Constructor para inicializar los atributos de la clase Curso
    public Curso(string nombreCurso, string profesor)
    {
        this.nombreCurso = nombreCurso;
        this.profesor = profesor;

        estudiantes = new Estudiante[3];
    }
    // metodo para agregar un estudiante al curso
    public void AgregarEstudiante(Estudiante estudiante)
    {
        for (int i = 0; i < estudiantes.Length; i++)
        {
            if (estudiantes[i] == null)
            {
                estudiantes[i] = estudiante;
                return;
            }
        }
        //no se pueden agregar más estudiantes
        Console.WriteLine("No se pueden agregar más estudiantes.");
    }
    // metodo para calcular el promedio de notas del curso
    public double PromedioCurso()
    {
        double suma = 0;
        int cantidad = 0;

        for (int i = 0; i < estudiantes.Length; i++)
        {
            if (estudiantes[i] != null)
            {
                suma += estudiantes[i].GetNotaFinal();
                cantidad++;
            }
        }

        if (cantidad == 0)
        {
            return 0;
        }

        return suma / cantidad;
    }
    // metodo para encontrar el estudiante con la mejor nota final del curso
    public Estudiante MejorEstudiante()
    {
        Estudiante mejor = estudiantes[0];

        for (int i = 1; i < estudiantes.Length; i++)
        {
            if (estudiantes[i] != null &&
                estudiantes[i].GetNotaFinal() >
                mejor.GetNotaFinal())
            {
                mejor = estudiantes[i];
            }
        }

        return mejor;
    }
}