using System;

namespace PasoPorValorYReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 7;
            Funcion1(numero);
            Console.WriteLine(numero);


            int[] miArray = { 3, 5 };
            Funcion2(miArray);
            Console.WriteLine(miArray[0]);
        }

        static void Funcion1(int numero)
        {
            numero = numero/2;
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número era múltiplo de 4");
            }
        }

        static void Funcion2(int[] array)
        {
            array[0] = 2 * array[0];
        }

        static void Funcion3(int[] array)
        {
            array = new int[10];
            array[0] = 9;
        }
    }
}
