using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int result = 0;

            Console.WriteLine("Digite seu 1° numero  desejado");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu 2° numero  desejado");
            num2 = double.Parse(Console.ReadLine());

            Console.Clear();

            while (result != 5) 
            {
                Console.WriteLine("Para somar Digite 1");
                Console.WriteLine("Para subtrair Digite 2");
                Console.WriteLine("Para dividir Digite 3");
                Console.WriteLine("Para multiplicar Digite 4");
                Console.WriteLine("Para sair Digite 5");
                result = int.Parse(Console.ReadLine());
                if (result == 1 ) 
                {
                    Console.WriteLine("Soma = {0}", num1 + num2);
                }
                if (result == 2 ) 
                {
                    Console.WriteLine("Subtração = {0}", num1 - num2);
                }
                if (result == 3 ) 
                {
                    Console.WriteLine("Divisão = {0}", num1 / num2);
                }
                if (result == 4 )
                {
                    Console.WriteLine("Multiplição = {0}", num1 * num2);
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}