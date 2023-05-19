using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteEvellyn.Models
{
    public class Carro
    {
        public string? Modelo { get; set; }
        public string? Cor { get; set; }
        public string? Rodas { get; set; }

        // public Carro(string modelo, string cor, string rodas)
        // {
        //     Modelo = modelo;
        //     Cor = cor;
        //     Rodas = rodas;
        // }
        public override string ToString()
        {
           return $"Modelo = {Modelo}, Cor = {Cor}, Rodas = {Rodas}";
        }
    }
}