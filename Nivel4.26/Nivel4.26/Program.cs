using System;

namespace Nivel4._26
{
    class Program
    {
        static void Main(string[] args)
        {
            //26) Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.

           
            for (int contador = 100; contador >= 1; contador--)
            {
                Console.WriteLine($"{contador}");


            }
            Console.ReadLine();
        }
    }
}
