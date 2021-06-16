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
                Console.WriteLine("Informe quantos metros quadrados da area: ex: 15");
                float MetrosQuadrados = VerificarNum(Console.ReadLine());

                float litros = MetrosQuadrados / 3;
                float latas = litros / 18;


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
