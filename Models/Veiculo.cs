using System;
using System.Collections.Generic;

namespace EstacionamentoEmCsharp.Models
{
    public class Veiculo
    {
        public List<string> veiculos = new List<string>();

        public class Moto
        {
            public string Modelo { get; set; }
            public DateTime Ano { get; set; }
            public string Marca { get; set; }
            public string Placa { get; set; }

            public static void AdicionaMoto(string placa)
            {
                
                if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {

                }
            }
        }
        public class Carro
        {
            public string Modelo { get; set; }
            public DateTime Ano { get; set; }
            public string Marca { get; set; }
            public string Placa { get; set; }

            public static void AdicionaCarro(string placa)
            {

            }
        }
    }

}