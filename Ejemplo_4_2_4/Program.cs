using System;

namespace Ejemplo_4_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ristra = "0001010001000101000100010100010001010001000101000100010100010001010001000101000100010100010001010001";
            string ristra = "0000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000";
            int[,] automata = InicializarAutomata(ristra);
            RellenarAutomata(automata);
            MostrarAutomata(automata);
        }

        static int[,] InicializarAutomata(string ristra)
        {
            int[,] automata = new int[100, 100];
            //Introducimos la primera ristra en el autómata
            for (int columna = 0; columna < automata.GetLength(1); ++columna)
            {
                automata[0, columna] = int.Parse($"{ristra[columna]}");
            }

            return automata;
        }

        static void RellenarAutomata(int[,] automata)
        {
            //Rellenamos el resto del autómata
            for (int fila = 1; fila < automata.GetLength(0); ++fila)
            {
                //Aquí rellenamos la fila i a partir de la fila i-1
                //Primera y última columna son cero siempre
                automata[fila, 0] = 0;
                automata[fila, automata.GetLength(1) - 1] = 0;
                //Ahora rellenamos cada elemento de la fila que no es un extremo
                for (int columna = 1; columna < automata.GetLength(1) - 1; ++columna)
                {
                    automata[fila, columna] = AplicarRegla1(automata[fila - 1, columna - 1],
                                                            automata[fila - 1, columna],
                                                            automata[fila - 1, columna + 1]);
                }
            }
        }


        static int AplicarRegla1(int arribaIzquierda, int arriba, int arribaDerecha)
        {
            string triplete = $"{arribaIzquierda}{arriba}{arribaDerecha}";
            int resultado = 1;
            switch (triplete)
            {
                case "000":
                case "011":
                case "110":
                    resultado = 0;
                    break;
            }

            /*
            int numero = arribaIzquierda * 4 + arriba * 2 + arribaDerecha;
            if (numero % 3 == 0)
            {
                resultado = 0;
            }
            */
            return resultado;
        }

        static void MostrarAutomata(int[,] automata)
        {
            //Mostramos el resultado por pantalla
            for (int fila = 0; fila < automata.GetLength(0); ++fila)
            {
                for (int columna = 0; columna < automata.GetLength(1); ++columna)
                {
                    if (automata[fila, columna] == 1)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }



    }
}
