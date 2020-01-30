using System;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do Dolar? ");
            double cotacaoDolar = Double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double valorCompra = Double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = " + ConversorMoeda.DolarReais(cotacaoDolar,valorCompra).ToString("F2"));
        }
    }
}
