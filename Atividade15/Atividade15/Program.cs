using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Atividade15
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe quantos você ganha por hora trabalhada: ex: 15");
                float salarioPorHora = VerificarNum(Console.ReadLine());

                Console.WriteLine("Informe quantas horas trabalhadas no mês: ex: 10");
                float HoraTrabalhada = VerificarNum(Console.ReadLine());

                float SalarioBruto = salarioPorHora * HoraTrabalhada;
                float ImpostoRenda = (SalarioBruto * (11f / 100f));
                float INSS = (SalarioBruto * (8f / 100f));
                float Sindicato = SalarioBruto * (5f / 100f);
                float SalarioLiquido = (SalarioBruto - (ImpostoRenda + INSS + Sindicato));

                Console.WriteLine($"Seu salario bruto é R${SalarioBruto} e o Liquido é R${SalarioLiquido}.");
                Console.WriteLine($"Você pagou R${ImpostoRenda} de imposto de renda, R${INSS} de INSS é R${Sindicato} de Sindicato. ");
                TentaNovamente();


            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                TentaNovamente();
            }


        }

        static float VerificarNum(string valor)
        {
            valor = valor.Replace(".", ",");

            if (!Regex.IsMatch(valor, @"^[1-9]\d{0,2}(\.\d{3})*(.\d+)?$"))
            {
                throw new Exception($"O valor \"{valor}\" informado não é valido.");
            }

            return float.Parse(valor);
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
                    Console.WriteLine("Resposta errada");
                    TentaNovamente();
         
                    break;
            }

        }

    }
}
