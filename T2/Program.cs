using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("¿Cuántas notas deseas ingresar? ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] notas = new int[cantidad];

        // Ingreso y validación
        for (int i = 0; i < cantidad; i++)
        {
            int nota;

            do
            {
                Console.Write($"\nIngresa la nota {i + 1}: ");
                nota = int.Parse(Console.ReadLine());

                if (nota < 0 || nota > 20)
                {
                    Console.WriteLine("Nota inválida, ingresa entre 0 y 20.");
                }

            } while (nota < 0 || nota > 20);

            notas[i] = nota;
        }

        // Mostrar notas válidas
        Console.WriteLine("\nNotas ingresadas:");

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine(notas[i]);
        }

        Console.ReadKey();
    }
}