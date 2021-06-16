using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Atividade14
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Atividade 14. João Papo-de-Pescador, homem do bem, comprou um microcomputador para controlar o rednimento diário de seu trabalho.
             * Toda vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente.
             * João precisa que você faça um programa que leia a variável peso(peso de peixes) e calcule o excesso. ravar na variável excesso a quantidade de quilos além do limite e na variável multa o valor da multa que João deverá pagar.
             * Imprima os dados do programa com as mensagens adequadas.*/

            Console.WriteLine("Informe o peso dos peixes:");

            var valor = Console.ReadLine().Replace(".", ",");

            if (Regex.IsMatch(valor, @"^[1-9]\d{0,2}(\.\d{3})*(.\d+)?$"))
            {
                float peso = float.Parse(valor);

                if (peso > 50)
                {
                    float pesoExc = peso - 50;

                    float excesso = pesoExc * 4;

                    Console.WriteLine($"Você ira pagar {excesso} reais por {pesoExc} quilos em excesso. ");
                    Console.ReadLine();
                }
                else if (peso < 50)
                {
                    Console.WriteLine("Peso informado dentro do regulamento de pesca de São Paulo (50 kilos) portanto nao ira pagar taxa.");
                }

                Console.WriteLine("Deseja reexecutar ? [S] sim ou [N] não");
                string res = Console.ReadLine().ToUpper();
                switch (res)
                {
                    case "S" :
                        Console.Clear();
                        Main(new string[] { });
                        break;
                    case "N":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Resposta errada");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Informe apenas numeros. Ex: 10,5");
                Thread.Sleep(2000);
                Console.Clear();
                Main(new string[] { });
            }
        }
    }
}
