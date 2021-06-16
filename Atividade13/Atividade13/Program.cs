using System;

namespace Atividade13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Atividade 13. tendo como dados de entrada a altura (h) de uma pessoa, 
               construa um algoritmo que calcule seu peso ideal, usando a seguinte fórmula:
                a. Para homens: (72.7*h) -58
                b. Para mulheres: (62.1*h) - 44.7 
            */

            Console.WriteLine("Informe seu sexo: Ex: f ou m");
            string sexo = Console.ReadLine();
  
            if (sexo=="f") 
            {
                Console.WriteLine("Informe a altura da pessoa. Ex: 1,75");
                float h = float.Parse(Console.ReadLine());

                float PesoI = (float)((62.1 * h) - 44.7);

                Console.WriteLine($"O peso ideal para uma mulher com {h} Cm de altura é {PesoI} Kg");
                Console.ReadLine();

            }
            else if(sexo=="m") 
            {
                Console.WriteLine("Informe a altura da pessoa. Ex: 1,75");
                float h = float.Parse(Console.ReadLine());

                float PesoI = (float)((72.7 * h) - 58);

                Console.WriteLine($"O peso ideal para um homem com {h} Cm de altura é {PesoI} Kg");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Dados inseridos incorretamente");
            }
            
        }
    }
}
