using System;

namespace Ej3InsertionSort;

internal class InsertionSortLlegadas
{
    // Datos de llegada registrados por los jueces.
    private static readonly int[] TiemposLlegada = { 58, 54, 60, 52, 57, 56, 59 };

    private static void Main()
    {
        int[] tiemposOrdenados = (int[])TiemposLlegada.Clone();

        Console.WriteLine("Ejercicio 3 - Insertion Sort");
        Console.WriteLine("Tiempos de llegada: {" + string.Join(", ", tiemposOrdenados) + "}");
        Console.WriteLine();

        OrdenarYMostrarPasos(tiemposOrdenados);
    }

    // Ordena el arreglo y muestra el resultado de cada iteracion.
    private static void OrdenarYMostrarPasos(int[] tiempos)
    {
        int comparaciones = 0;
        int intercambios = 0;

        Console.WriteLine("Llegada 1: {" + tiempos[0] + "}");

        for (int i = 1; i < tiempos.Length; i++)
        {
            int posicion = i;

            // Inserta el tiempo actual en la parte ya ordenada.
            while (posicion > 0)
            {
                comparaciones++;

                if (tiempos[posicion] >= tiempos[posicion - 1])
                {
                    break;
                }

                int temporal = tiempos[posicion];
                tiempos[posicion] = tiempos[posicion - 1];
                tiempos[posicion - 1] = temporal;

                intercambios++;
                posicion--;
            }

            Console.WriteLine($"Llegada {i + 1}: {{" + string.Join(", ", tiempos[..(i + 1)]) + "}");
        }

        Console.WriteLine();
        Console.WriteLine("Comparaciones: " + comparaciones);
        Console.WriteLine("Intercambios: " + intercambios);
    }
}
