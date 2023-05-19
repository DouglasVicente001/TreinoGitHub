using System;
using TesteEvellyn.Models;

namespace TesteEvellyn
{
    class Program
    {
        static void Main(string[] args)
         {
        //     Carro carro = new Carro();
        //     carro.Modelo = "fordKa";
        //     carro.Cor = "rosa";
        //     carro.Rodas = "15";
        //     System.Console.WriteLine($"{carro.Modelo} {carro.Cor} {carro.Rodas}");
            
        System.Console.WriteLine("Insira um valor");
        string entrada = Console.ReadLine();

        int numero;
        if (int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Você digitou o número: " + numero);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
            }
            string modelinho  = "s22";
            string modelinho2  = "azul";
            string modelinho3  = "aro 15";
            
            var result = (new Carro() {Modelo = modelinho, Cor = modelinho2, Rodas = modelinho3});

            System.Console.WriteLine(result);
           
        }
    }
}

