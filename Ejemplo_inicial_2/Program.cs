using System;

namespace Ejemplo_inicial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número de filas");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el número de columnas");
            int columnas = int.Parse(Console.ReadLine());

            string[,] matriz = new string[filas, columnas];
            //Rellenamos con ceros
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    matriz[i, j] = "_";
                }
            }

            //Ponemos en un lugar al azar un asterisco
            Random generador = new Random();
            int filaAleatoria = generador.Next(0, matriz.GetLength(0));
            int columnaAleatoria = generador.Next(0, matriz.GetLength(1));
            matriz[filaAleatoria, columnaAleatoria] = "*";

            //Pedimos una fila y una columna al usuario
            //Convendría asegurarse de que los valores introducidos
            //son válidos
            bool hemosAcertado = false;
            do
            {
                Console.WriteLine("¿En qué fila crees que se encuentra el asterisco?");
                int fila = int.Parse(Console.ReadLine());
                Console.WriteLine("¿En qué columna crees que se encuentra el asterisco?");
                int columna = int.Parse(Console.ReadLine());
                
                if (matriz[fila, columna] == "*")
                {
                    Console.WriteLine("Muy bien, has acertado");
                    hemosAcertado = true;
                }
                else
                {
                    if (fila < filaAleatoria)
                    {
                        Console.WriteLine("El asterisco está debajo");
                    }
                    else if (fila > filaAleatoria)
                    {
                        Console.WriteLine("El asterisco está encima");
                    }
                    if (columna < columnaAleatoria)
                    {
                        Console.WriteLine("El asterisco está a la derecha");
                    }
                    else if (columna > columnaAleatoria)
                    {
                        Console.WriteLine("El asterisco está a la izquierda");
                    }

                }
            } while (!hemosAcertado);



        }
    }
}
