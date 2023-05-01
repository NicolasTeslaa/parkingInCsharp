using EstacionamentoEmCsharp.Models;

namespace parkingInCsharp
{
    public  class Menu
    {
        public static void ChamaMenu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao Estacionamento");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Digite o preço inicial");
            var precoInicial = Convert.ToDecimal(Console.ReadLine());
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Digite o preço por hora");
            var precoHora = Convert.ToDecimal(Console.ReadLine());
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Digite a opção");
            Console.WriteLine("1- Cadastrar Veiculo");
            Console.WriteLine("2- Remover Veiculo");
            Console.WriteLine("3- Listar Veiculos");
            Console.WriteLine("4- Encerrar Sistema");
            var opcao = (Console.ReadLine());
            Estacionamento es = new Estacionamento(precoInicial, precoHora);

            switch (opcao)
            {
                case "1":
                    es.adicionarVeiculo();
                    break;
                case "2":
                    es.removerVeiculo();
                    break;
                case "3":
                    es.listarVeiculo();
                    break;
            }
        }

    }
}