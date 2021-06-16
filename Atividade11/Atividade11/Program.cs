using System;

namespace Atividade11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Atividade 11. Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre:
            a. o produto do dobro do primeiro com metade do segundo.
            b. a soma do triplo do primeiro com o terceiro.
            c. o terceiro elevado ao cubo. */

            Console.WriteLine("Informe o primeiro Número: ");
            float Num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo Número: ");
            float Num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe um Número real: ");
            float Num3 = float.Parse(Console.ReadLine());

            float A = (Num1 * 2) * (Num2/2);
            float B = (Num1 * 3) + (Num3);
            float C = (Num3 * Num3 * Num3);

            Console.WriteLine($"a. O produto do dobro do primeiro com metade do segundo é: {A}");
            Console.WriteLine($"b. a soma do triplo do primeiro com o terceiro é: {B}");
            Console.WriteLine($"c. o terceiro elevado ao cubo é: {C}");
            Console.ReadLine();

        }
    }
}
