using System;
using System.Threading;

Console.Clear();
Console.WriteLine("Bem vindo ao Estacionamento");
Thread.Sleep(3000);
Console.Clear();
Console.WriteLine("Digite o preço inicial");
var precoInicial = (Console.ReadLine());
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Digite o preço por hora");
var precoHora = (Console.ReadLine());
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Digite a opção");
Console.WriteLine("1- Cadastrar Veiculo");
Console.WriteLine("2- Remover Veiculo");
Console.WriteLine("3- Listar Veiculos");
Console.WriteLine("4- Encerrar Sistema");

