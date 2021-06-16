using System;

namespace Atividade10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Atividade 10. Faça um Programa que peça a temperatura em graus Celsius, 
             transforme e mostre em graus Fahrenheit. */

            Console.WriteLine("Informe a temperatura em Celsius: ");
            float Cel = float.Parse(Console.ReadLine());

            float Fah = (float)(Cel * 1.8 + 32);

            Console.WriteLine($"{Cel}°C em Fahrenheit é: {Fah}°F"); 
            Console.ReadLine();
        }
    }
}
