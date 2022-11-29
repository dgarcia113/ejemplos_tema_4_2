using System;

namespace Ejemplo_inicial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una matriz bidimensional
            int[,] matriz = new int[3, 5];
            //Rellenamos con números aleatorios
            //GetLength nos devuelve la longitud del array
            //en una determinada dimensión
            Random generador = new Random();
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                for (int j=0; j < matriz.GetLength(1); ++j)
                {
                    matriz[i, j] = generador.Next(1, 11);
                }
            }
            /*
            //Imprimimos la matriz
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
            Console.WriteLine("Y ahora, traspuesta:");
            //Imprimimos la matriz traspuesta
            for (int i = 0; i < matriz.GetLength(1); ++i)
            {
                for (int j = 0; j < matriz.GetLength(0); ++j)
                {
                    Console.Write(matriz[j, i]);
                    if (j < matriz.GetLength(0))
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            */

            //Arrays escalonados
            int[][] escalonado = new int[6][];
            //Cada fila del array escalonado puede tener distinta longitud
            for (int i = 0; i < escalonado.Length; ++i)
            {
                escalonado[i] = new int[generador.Next(1, 10)];
                for (int j = 0; j < escalonado[i].Length; ++j)
                {
                    escalonado[i][j] = generador.Next(-10, 11);
                }
            }

            //Mostramos el array
            for (int i = 0; i < escalonado.Length; ++i)
            {
                for (int j = 0; j < escalonado[i].Length; ++j)
                {
                    Console.Write(escalonado[i][j]);
      
                    if (j < escalonado[i].Length - 1)
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
