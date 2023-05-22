 using System;
using TesteEvellyn.Models;
using TesteEvellyn.Trabalho;

namespace TesteEvellyn
{
    class Program
    {
        static void Main(string[] args)
        {

        Calculadora calculadora = new Calculadora();
        calculadora.Bala = 5;
        calculadora.Chiclete = 3;
        int resposta = calculadora.CalcularBalaMaisChiclete();

        calculadora.Pirulito = 9;
        int resultado = calculadora.CalcularBalaMaisPirulito();
        int respostaFinal = resultado + resposta;
        System.Console.WriteLine(respostaFinal);
        }

    }
}

