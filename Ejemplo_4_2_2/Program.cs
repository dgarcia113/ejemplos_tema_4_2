using System;

namespace Ejemplo_4_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la matriz: las filas van separadas por | y las columnas por espacios");
            string matrizEnCadena = Console.ReadLine();

            int[,] matriz = ComponerMatriz(matrizEnCadena);
            int[,] traspuesta = CalcularMatrizTraspuesta(matriz);
            Console.WriteLine("La matriz traspuesta es:");
            ImprimirMatriz(traspuesta);
        }

        static int[,] ComponerMatriz(string cadena)
        {
            //Necesitamos averiguar el número de filas y el número de columnas por fila
            string[] matrizEnFilas = cadena.Split('|');
            int filas = matrizEnFilas.Length;
            string[] primeraFila = matrizEnFilas[0].Split(' ');
            int columnas = primeraFila.Length;

            int[,] matriz = new int[filas, columnas];
            //Rellenamos la matriz con los datos introducidos
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                string[] fila = matrizEnFilas[i].Split(' ');
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    matriz[i, j] = int.Parse(fila[j]);
                }
            }
            return matriz;
        }


        static int[,] CalcularMatrizTraspuesta(int[,] matriz)
        {
            int[,] traspuesta = new int[matriz.GetLength(1), matriz.GetLength(0)];
            for (int i = 0; i < matriz.GetLength(0);++i)
            {
                for (int j = 0; j < matriz.GetLength(1);++j)
                {
                    traspuesta[j, i] = matriz[i, j];
                }
            }
            return traspuesta;
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
