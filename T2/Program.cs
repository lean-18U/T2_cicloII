using System;
class Program
{
    static void CalcularDatos(int[] notas, int cantidad, ref double promedio, ref int maxima, ref int minima)
    {
        int suma=0;
        maxima=notas[0];
        minima=notas[0];

        for(int i=0; i<cantidad;i++)
        {
        suma+=notas[i];

            if (notas[i]>maxima)
            {
            maxima=notas[i];
            }

            if (notas[i]<minima)
            {
            minima=notas[i];
            }
        }

        promedio =(double)suma/cantidad;
    }
    static int ContarAprobados(int[]notas,int cantidad)
    {
        int aprobados=0;
        for (int i=0;i<cantidad;i++)
        {
            if (notas[i]>=12)
            {
            aprobados++;
            }
        }
        return aprobados;
    }
    static void Main(string[] args)
    {
        Console.Write("¿Cuántas notas deseas ingresar? ");
        int cantidad = int.Parse(Console.ReadLine());
        int[] notas=new int[cantidad];
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
        double promedio = 0;
        int maxima = 0;
        int minima = 0;
        CalcularDatos(notas, cantidad, ref promedio, ref maxima, ref minima);
        int aprobados = ContarAprobados(notas, cantidad);
        Console.WriteLine("\n--- Datos Calculados ---");
        Console.Write("Notas ingresadas: [");
        for (int i = 0; i < cantidad; i++)
        {
        Console.Write(notas[i]);
        if (i < cantidad - 1)
            {
        Console.Write(", ");
            }
        }
        Console.WriteLine("]");
        Console.WriteLine($"\nPromedio      : {promedio:F2}");
        Console.WriteLine($"Nota máxima   : {maxima}");
        Console.WriteLine($"Nota mínima   : {minima}");
        Console.WriteLine($"Aprobados     : {aprobados}");
    }
}