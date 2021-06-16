using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atividade 2. Faça um Programa que peça um Número e então mostre a mensagem O número informado foi [número].
            
            Console.WriteLine("Informe um Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"O Numero Informado é: {numero} ");
            Console.ReadLine();
        }
    }
}
