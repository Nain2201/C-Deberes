using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una lista para almacenar las asignaturas
        List<string> asignaturas = new List<string>();

        // Añadir asignaturas a la lista
        asignaturas.Add("Matemáticas");
        asignaturas.Add("Física");
        asignaturas.Add("Química");
        asignaturas.Add("Historia");
        asignaturas.Add("Lengua");

        // Mostrar las asignaturas por pantalla
        Console.WriteLine("Las asignaturas del curso son:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}
