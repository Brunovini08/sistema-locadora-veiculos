using sistema_locadora_veiculos.Pessoa.Pessoa;
using sistema_locadora_veiculos.Veiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Locacao
{
    public class LocacaoBase
    {
        private static int contador { get; set; } = 1;
        public PessoaBase Pessoa { get; private set; }
        public VeiculoBase Veiculo { get; private set; }
        public DateOnly DataInicioLocacao { get; private set; }
        public DateOnly? DataFimLocacao { get; private set; }
        public int Id { get; private set; }
        public double? Valor { get; private set; }

        public LocacaoBase(PessoaBase pessoa, VeiculoBase veiculo)
        {
            this.Pessoa = pessoa;
            this.Veiculo = veiculo;
            this.DataInicioLocacao = DateOnly.FromDateTime(DateTime.Now);
            this.Id = contador++;
            this.Veiculo.Disponivel = false;
        }

        public int CalcularTempoDeAluguel(DateOnly dataInicial, DateOnly dataFim)
        {
            int data = dataFim.DayOfYear - dataInicial.DayOfYear;
            return data;
        }

        public LocacaoBase FinalizarLocacao(DateOnly dataFimLocal, int id)
        {
            if (this.Id == id)
            {
                this.DataFimLocacao = dataFimLocal;
                int diasAlugado = this.CalcularTempoDeAluguel(this.DataInicioLocacao, dataFimLocal);
                this.Valor = diasAlugado * this.Veiculo.ValorAluguel;
                this.Veiculo.Disponivel = true;
                return this;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("─────────────────────────────────────────");
            sb.AppendLine($"ID da Locação:  {this.Id}");
            sb.AppendLine($"Cliente:        {this.Pessoa.ToString()}");
            sb.AppendLine($"Veículo:        {this.Veiculo.ToString()}");
            sb.AppendLine($"Data:           {this.DataInicioLocacao}");
            sb.AppendLine($"{(this.Valor != 0 ? ($"Valor a pagar: {this.Valor}") : "")}");
            return sb.ToString();
        }
    }
}
