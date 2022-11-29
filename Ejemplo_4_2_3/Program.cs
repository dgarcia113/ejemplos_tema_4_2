using System;

namespace Ejemplo_4_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la matriz: las filas van separadas por | y las columnas por espacios");
            string matrizEnCadena = Console.ReadLine();

            int[][] matriz = ComponerMatriz(matrizEnCadena);
            float[] medias = CalcularLasMedias(matriz);
            int indiceValorMasAlto = BuscarIndiceDeValorMasAlto(medias);

            Console.WriteLine($"El alumno con la nota media más alta " +
                $"está en la posición {indiceValorMasAlto}, y su nota " +
                $"media es {medias[indiceValorMasAlto]}");

        }

        static int[][] ComponerMatriz(string cadena)
        {
            //Necesitamos averiguar el número de filas y el número de columnas por fila
            string[] matrizEnFilas = cadena.Split('|');
            int filas = matrizEnFilas.Length;
            

            int[][] matriz = new int[filas][];
            //Rellenamos la matriz con los datos introducidos
            for (int i = 0; i < matriz.Length; ++i)
            {
                string[] fila = matrizEnFilas[i].Split(' ');
                matriz[i] = new int[fila.Length];
                for (int j = 0; j < matriz[i].Length; ++j)
                {
                    matriz[i][j] = int.Parse(fila[j]);
                }
            }
            return matriz;
        }

        static float[] CalcularLasMedias(int[][] notas)
        {
            float[] medias = new float[notas.Length];
            for (int i = 0; i < notas.Length; ++i)
            {
                //Calculamos la media de la fila i de notas
                medias[i] = CalcularMediaDeUnAlumno(notas[i]);
            }
            return medias;
        }

        static float CalcularMediaDeUnAlumno(int[] notas)
        {
            float media = 0;
            for (int i = 0; i < notas.Length; ++i)
            {
                media += notas[i];
            }
            media /= notas.Length;
            return media;
        }

        static int BuscarIndiceDeValorMasAlto(float[] datos)
        {
            float maximo = float.MinValue;
            int indiceMaximo=0;
            for (int i = 0; i < datos.Length; ++i)
            {
                if (datos[i]>maximo)
                {
                    indiceMaximo = i;
                    maximo = datos[i];
                }
            }
            return indiceMaximo;
        }
    }
}
