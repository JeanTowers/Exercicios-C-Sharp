using System;
using System.Text.RegularExpressions;

namespace NIvel4._27
{
    class Program
    {
        static void Main(string[] args)
        {
            //27)  Escreva um programa que leia: - a quantidade de números que deverá processar;
            //- os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial.
            //Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N

            try
            {
                Console.WriteLine("Informe a quantidade de números que ira fatoriar:");
                int Num = VerificarNum(Console.ReadLine());

                long[] numeros = new long[Num];

                for (int contador = 0; contador < Num; contador++)
                {
                    Console.WriteLine($"Informe o {contador + 1}º Número:");
                    numeros[contador] = VerificarNum(Console.ReadLine());
                }

                long total = 1;
                long[] respostas = new long[Num];

                for (int itemArrayNumeros = 0; itemArrayNumeros < numeros.Length; itemArrayNumeros++)
                {
                    for (int contador = 0; contador < numeros[itemArrayNumeros]; contador++)
                        total = total * (contador + 1);

                    respostas[itemArrayNumeros] = total;
                }

                for (int i = 0; i < respostas.Length; i++)
                    Console.WriteLine($"Fatorial de {numeros[i]} é {respostas[i]}");

                TentaNovamente();
                Console.ReadLine();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                TentaNovamente();
            }
        }
        static int VerificarNum(string valor)
        {
            valor = valor.Replace(".", ",");

            if (!Regex.IsMatch(valor, @"^[1-9]\d{0,2}(\.\d{3})*(.\d+)?$"))
            {
                throw new Exception($"O valor \"{valor}\" informado não é valido.");
            }

            return int.Parse(valor);
        }
        static void TentaNovamente()
        {
            Console.WriteLine("Deseja tentar novamente? \"S\" para SIM é \"N\" para NÂO");
            switch (Console.ReadLine().ToUpper())
            {
                case "S":
                    Console.Clear();
                    Main(new string[] { });
                    break;
                case "N":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Resposta Errada");
                    TentaNovamente();
                    break;

            }
        }
    }
}
