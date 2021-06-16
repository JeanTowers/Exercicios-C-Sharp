using System;

namespace Atividade9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Atividade 9. Faça um Programa que peça a temperatura em graus Fahrenheit, 
              transforme e mostre a temperatura em graus Celsius. C= 5*((F-32)/9).*/

            Console.WriteLine("Informe a temperatura em Fahrenheit: ");
            float Fah = float.Parse(Console.ReadLine());

            float Cel = 5 * ((Fah - 32) / 9);

            Console.WriteLine($"A temperatura em Celsius é: {Cel}°C");
            Console.ReadLine();
        }
    }
}
