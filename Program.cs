using System;
using System.Collections.Generic;

namespace Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4) Construir una función que reciba dos vectores enteros de igual tamaño  
            //   y retorne un 1 si son iguales o un 0 sino lo son.

            List<int> lista1 = new List<int>();
            int tamanioVector = 5;

            for (int i = 0; i < tamanioVector; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                lista1.Add(int.Parse(Console.ReadLine()));
            }

            List<int> lista2 = new List<int>();

            for (int i = 0; i < tamanioVector; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                lista2.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(SonIguales(lista1, lista2));
        }

        public static bool SonIguales(List<int> lista1, List<int> lista2)
        {
            for (int i = 0; i < lista1.Count; i++)
            {                
                if (lista1[i] != lista2[i])
                    return false;
            }
            return true;
        }
    }
}
