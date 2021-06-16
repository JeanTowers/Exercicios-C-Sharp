using System;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atividade 4. Faça um Programa que peça as 4 notas bimestrais e mostre a média.

            Console.WriteLine("Informe a primeira nota bimestral: ");

            float Num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota bimestral: ");

            float Num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota bimestral: ");

            float Num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota bimestral: ");

            float Num4 = float.Parse(Console.ReadLine());

            float resultado = (Num1 + Num2 + Num3 + Num4) / 4;

            Console.WriteLine($"A média das 4 notas bimestrais são {resultado} ");
            Console.ReadLine();
        }
    }
}
