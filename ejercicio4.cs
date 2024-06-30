using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una lista para almacenar los números ganadores
        List<int> numerosGanadores = new List<int>();

        // Pedir al usuario que ingrese los números ganadores
        Console.WriteLine("Ingresa los números ganadores de la lotería primitiva (ingresa '0' para terminar):");
        int numero;
        do
        {
            Console.Write("Número ganador (o '0' para terminar): ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                numerosGanadores.Add(numero);
            }

        } while (numero != 0);

        // Ordenar la lista de números ganadores de menor a mayor
        numerosGanadores.Sort();

        // Mostrar los números ganadores ordenados
        Console.WriteLine("\nNúmeros ganadores ordenados de menor a mayor:");
        foreach (var num in numerosGanadores)
        {
            Console.WriteLine(num);
        }
    }
}
