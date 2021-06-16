using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro Número: ");
            int Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo Número: ");
            int Num2 = int.Parse(Console.ReadLine());

            int resultado = Num1 + Num2;
            Console.WriteLine($"O Primeiro Número:{Num1} + o Segundo Número:{Num2} resulta no Número:{resultado}");
            Console.ReadLine();
        }
    }
}
