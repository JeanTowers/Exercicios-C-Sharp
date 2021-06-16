using System;

namespace Atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
             /*Atividade 7. Faça um Programa que calcule a área de um quadrado,
             em seguida mostre o dobro desta área para o usuario. */
           
            Console.WriteLine("Informe o lado do quadrado:");
            float lado = float.Parse(Console.ReadLine());

            float area = lado * lado;

            float areaDobro = area * area;

            Console.WriteLine($"A área do quadrado é: {area}. ja o dobro da área é: {areaDobro}");
            Console.ReadLine();

        }
    }
}
