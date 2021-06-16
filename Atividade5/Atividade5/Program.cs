using System;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atividade 5. Faça um Programa que converta metros para centimetros.

            Console.WriteLine("Informe quantos metros quer convertar para centimetros. ex: '1,75' ou '2'");
            float metros = float.Parse(Console.ReadLine());
            float centimetros = metros * 100;

            Console.WriteLine($"{metros} metros da {centimetros} centimetros.");
            Console.ReadLine();
        }
    }
}
