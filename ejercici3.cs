using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una lista de asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        // Crear una lista para almacenar las notas
        List<double> notas = new List<double>();

        // Pedir al usuario que ingrese la nota para cada asignatura
        foreach (var asignatura in asignaturas)
        {
            Console.Write($"Ingresa la nota para {asignatura}: ");
            double nota = double.Parse(Console.ReadLine());
            notas.Add(nota);
        }

        // Mostrar cada asignatura con su respectiva nota
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
        }
    }
}
