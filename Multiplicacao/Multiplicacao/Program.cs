using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe Numero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe Numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 <= 0)
            {
                num1 = 0 - num1;
            }
            if (num2 <= 0)
            {
                num2 = 0 - num2;
            }

            int resultado = 0;

            for (int contador = 0; contador < num1; contador++)
            {
                resultado = resultado + num2;

            }

            Console.WriteLine("O resultado da mulplicação entre o número {0} e o número {1} é igual a {2}", num1, num2, resultado);
            Console.ReadLine();

        }
    }
}
