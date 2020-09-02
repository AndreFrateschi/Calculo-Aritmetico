using System;

namespace operadoresAritimeticos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double valor1, valor2;

            valor1 = 10;
            valor2 = 5;

            double soma = valor1 + valor2;
            double multiplicacao = valor1 * valor2;
            double divisao = valor1 / valor2;
            double subtracao = valor1 - valor2;

            Console.WriteLine("soma: " + soma);
            Console.WriteLine("multiplicacao: " + multiplicacao);
            Console.WriteLine("divisao: " + divisao);
            Console.WriteLine("subtracao: " + subtracao);




            Console.WriteLine("Hello World!");
        }
    }
}
