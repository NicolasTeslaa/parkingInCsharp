using System;
using System.Collections.Generic;
using parkingInCsharp;

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
            Console.WriteLine("E N T R A D A   D E   V E Í C U L O S");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Digite a placa do veiculo");
            var placa = (Console.ReadLine());
            Thread.Sleep(2000);
            Console.Clear();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Veiculo já existe");
                Thread.Sleep(2000);
                Console.Clear();
                Menu.ChamaMenu();
            }
            else
            {
                veiculos.Add(placa.Trim());
                Console.WriteLine("Veículo cadastrado com sucesso!\n");
                Thread.Sleep(2000);
                Console.Clear();
                Menu.ChamaMenu();
            }
            Thread.Sleep(2000);
            Console.Clear();
            Menu.ChamaMenu();
        }
        public void removerVeiculo()
        {
            int horas = 0;
            Console.Clear();
            Console.WriteLine("S A Í D A  D E  V E Í C U L O S");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Digite a placa do veículo para remover:");
            var placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo ficou:");
                Thread.Sleep(1000);
                Console.Clear();
                horas = int.Parse(Console.ReadLine());
                decimal valorTotal = 0;

                valorTotal = (precoInicial + precoHora) * horas;

                veiculos.Remove(placa.Trim());
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine($"O Veiculo {placa} foi removido e ficou no valor : {valorTotal}");
                Thread.Sleep(2000);
                Console.Clear();
                Menu.ChamaMenu();
            } else{
                Console.WriteLine("Veiculo nao encontrado");
            }
        }
        public void listarVeiculo()
        {
            if (veiculos.Any())
            {
                Console.Clear();
                Console.WriteLine("V E I C U L O S    E S T A C I O N A D O S");
                Thread.Sleep(3000);
                Console.Clear();
                int contador = 0;
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                    contador++;
                    Console.Clear();
                }
                Thread.Sleep(2000);
                Console.Clear();
                Menu.ChamaMenu();
            }
            else
            {
                Console.WriteLine("Não há veiculos estacionados no momento");
                Thread.Sleep(2000);
                Console.Clear();
                Menu.ChamaMenu();
            }
        }
    }
}