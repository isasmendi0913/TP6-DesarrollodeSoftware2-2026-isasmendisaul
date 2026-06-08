using System;

class Program
{
    static void Main()
    {
        // a) Crear un curso
        Curso curso =
            new Curso(
                "Programación I",
                "Prof. García");

        // b) Crear 4 estudiantes
        Estudiante e1 =
            new Estudiante(
                "Juan",
                "Pérez",
                1001,
                8);

        Estudiante e2 =
            new Estudiante(
                "Ana",
                "Gómez",
                1002,
                9);

        Estudiante e3 =
            new Estudiante(
                "Lucas",
                "Fernández",
                1003,
                7);

        Estudiante e4 =
            new Estudiante(
                "María",
                "López",
                1004,
                10);

        // c) Agregar estudiantes
        curso.AgregarEstudiante(e1);
        curso.AgregarEstudiante(e2);
        curso.AgregarEstudiante(e3);

        // d) Intentar agregar el cuarto
        curso.AgregarEstudiante(e4);

        // e) Mostrar promedio
        Console.WriteLine(
            $"Promedio del curso: {curso.PromedioCurso():0.00}");

        // f) Mostrar mejor estudiante
        Estudiante mejor = curso.MejorEstudiante();

        Console.WriteLine("\nMEJOR ESTUDIANTE");

        Console.WriteLine(
            $"Nombre: {mejor.GetNombre()}");

        Console.WriteLine(
            $"Apellido: {mejor.GetApellido()}");

        Console.WriteLine(
            $"Legajo: {mejor.GetLegajo()}");

        Console.WriteLine(
            $"Nota Final: {mejor.GetNotaFinal()}");
    }
}