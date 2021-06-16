using System;

namespace Atividade12
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Atividade 12. tendo como dados de entrada a altura de uma pessoa, 
               construa um algoritmo que calcule seu peso ideal, usando a seguinte fórmula: (72.7*altura) -58 */
            
            Console.WriteLine("Informe a altura da pessoa. Ex: 1,75");
            float Alt = float.Parse(Console.ReadLine());

            float PesoI = (float)((72.7 * Alt) - 58);

            Console.WriteLine($"O peso ideal para quem tem {Alt} Cm é {PesoI} Kg");
            Console.ReadLine();


        }
    }
}
