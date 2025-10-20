using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Veiculo
{
    public abstract class VeiculoBase
    {
        private static int contador { get; set; } = 1;
        public int Id { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public string Placa { get; private set; }
        public string Categoria { get; private set; }
        public string Combustivel { get; private set; }
        public bool Disponivel { get; set; }
        public double ValorAluguel { get; private set; }
        public VeiculoBase(string marca, string modelo, int ano, string placa, string categoria, string combustivel, double valorAluguel)
        {
            this.Id = contador++;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Placa = placa;
            this.Categoria = categoria;
            this.Combustivel = combustivel;
            this.Disponivel = true;
            this.ValorAluguel = valorAluguel;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"ID:                   {Id}");
            sb.AppendLine($"Marca:                {Marca}");
            sb.AppendLine($"Modelo:               {Modelo}");
            sb.AppendLine($"Ano:                  {Ano}");
            sb.AppendLine($"Placa:                {Placa}");
            sb.AppendLine($"Categoria:            {Categoria}");
            sb.AppendLine($"Combustível:          {Combustivel}");
            sb.AppendLine($"Disponível:           {(Disponivel ? "Sim" : "Não")}");
            sb.AppendLine($"Valor Aluguel diário: {ValorAluguel}");

            return sb.ToString();
        }

    }
}
