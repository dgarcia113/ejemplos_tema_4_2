using System;

namespace Ejemplo_4_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número de filas");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el número de columnas");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = GenerarMatriz(filas, columnas);
            ImprimirMatriz(matriz);            
        }

        static int[,] GenerarMatriz(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas];
            Random generador = new Random();
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    matriz[i, j] = generador.Next(-10, 11);
                }
            }
            return matriz;
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            //Mostramos el array
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    Console.Write(matriz[i, j]);
                    if (j < matriz.GetLength(1))
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
