using System;

namespace Atividade8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Atividade 8. Faça um Programa que pergunte quanto você ganha por hora
              e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês.*/
            
            Console.WriteLine("Informe quantos você ganha por hora: ");
            float salarioHora = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe quantas horas trabalhada por mês: ");
            float horaTrab = float.Parse(Console.ReadLine());

            float salarioTotal = salarioHora * horaTrab;

            Console.WriteLine($"Salario total: {salarioTotal}");
            Console.ReadLine();
        }
    }
}
