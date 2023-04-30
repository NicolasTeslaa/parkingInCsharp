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

        }
        public void removerVeiculo()
        {

        }
        public void listarVeiculo()
        {

        }
    }
}