using System;

namespace Atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atividade 6. Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.

            Console.WriteLine("Informe o raio  do círculo: ");
            int raio = int.Parse(Console.ReadLine());

            const float PI = 3.14159265359f;

            float area = PI *(raio*raio);

            Console.WriteLine($"A área do circulo é: {area} cm²");
            Console.ReadLine();


        }
    }
}
