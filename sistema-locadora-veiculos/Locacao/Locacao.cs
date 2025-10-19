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
        public PessoaBase Pessoa { get; private set; }
        public VeiculoBase Veiculo { get; private set; }
        public DateTime DataLocacao { get; private set; }

        public LocacaoBase(PessoaBase pessoa, VeiculoBase veiculo)
        {
            this.Pessoa = pessoa;
            this.Veiculo = veiculo;
            this.DataLocacao = DateTime.Now;
        }

    }
}
