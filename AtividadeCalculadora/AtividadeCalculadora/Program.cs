using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AtividadeCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe o Primeiro numero: ");
                float Num1 = VerificarNum(Console.ReadLine());

                Console.WriteLine("Informe o Operador:");
                Console.WriteLine(" + para Mais ");
                Console.WriteLine(" - para Menos ");
                Console.WriteLine(" / para Divisão ");
                Console.WriteLine(" * para Vezes ");
                string Operacao = VerificarOpe(Console.ReadLine());


                Console.WriteLine("Informe o Segundo numero: ");
                float Num2 = VerificarNum(Console.ReadLine());


                float Resultado = 0;

                switch (Operacao)
                {
                    case "+":
                        Resultado = Mais(Num1, Num2);
                        break;
                    case "-":
                        Resultado = Menos(Num1, Num2);
                        break;
                    case "/":
                        Resultado = Divisao(Num1, Num2);
                        break;
                    case "*":
                        Resultado = Vezes(Num1, Num2);
                        break;
                    default:
                        throw new Exception($"O operador \"{Operacao}\" informado não é valido.");
                        break;
                }

                Console.WriteLine($"{Num1} {Operacao} {Num2} = {Resultado}");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                TentaNovamente();
            }
            Console.ReadLine();

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

        static string VerificarOpe(string operacao)
        {
            string[] operadores = { "+", "-", "/", "*" };

            if (!operadores.Contains(operacao))
                throw new Exception($"O operador \"{operacao}\" informado não é valido.");

            return operacao;
        }


        static float Mais(float Num1, float Num2)
        {
            float Numero = Num1 + Num2;
            return (Numero);
        }
        static float Menos(float Num1, float Num2)
        {
            float Numero = Num1 - Num2;
            return (Numero);
        }
        static float Divisao(float Num1, float Num2)
        {
            float Numero = Num1 / Num2;
            return (Numero);
        }
        static float Vezes(float Num1, float Num2)
        {
            float Numero = Num1 * Num2;
            return (Numero);
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
