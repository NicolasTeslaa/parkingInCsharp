using System;
using System.Collections.Generic;

namespace EstacionamentoEmCsharp.Models
{
    public class Estacionamento
    {
        public decimal precoInicial = 0;
        public decimal precoHora = 0;
        public List<string> veiculos = new List<string>();

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
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Veiculo já existe");
                Thread.Sleep(2000);
                Console.Clear();
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