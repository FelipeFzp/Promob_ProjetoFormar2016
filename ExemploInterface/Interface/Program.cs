using ExemploInterface;
using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Onibus onibus = new Onibus(25, 2015, "Preta", "Bus");
            Carro carro = new Carro();
            

            VeiculoManager manager = new VeiculoManager();
            manager.CarregarVeiculo(onibus);
            manager.CarregarVeiculo(carro);

            manager.CarregarVeiculoTransporte(onibus);

            Console.ReadLine();
        }
    }
}
