using System;
using System.Collections.Generic;

namespace EstacionamentoEmCsharp.Models
{
    public class Estacionamento
    {
        public decimal precoInicial { get; set; }
        public decimal precoHora { get; set; }
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoHora = precoHora;
            this.precoInicial = precoInicial;
        }
        public void adicionarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veiculo");
            var placa = (Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Seu veiculo é uma moto ou um carro?");
            var opcao = (Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                case "moto": Veiculo.Moto.AdicionaMoto(); break;
                case "carro": Veiculo.Carro.AdicionaCarro(); break;
            }

        }
        public void removerVeiculo()
        {

        }
        public void listarVeiculo()
        {

        }
    }
}