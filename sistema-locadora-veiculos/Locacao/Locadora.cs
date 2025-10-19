using sistema_locadora_veiculos.Locacao;
using sistema_locadora_veiculos.Pessoa.Pessoa;
using sistema_locadora_veiculos.Veiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Locacoes
{
    public class Locadora
    {
        public List<PessoaBase> Clientes { get; private set; }
        public List<VeiculoBase> Veiculos { get; private set; }
        public List<LocacaoBase> Locacoes { get; private set; }

        public Locadora()
        {
            this.Locacoes = new List<LocacaoBase>();
            this.Clientes = new List<PessoaBase>();
            this.Veiculos = new List<VeiculoBase>();
        }

        public void CadastrarCliente(PessoaBase pessoa)
        {
            this.Clientes.Add(pessoa);
        }

        public void CadastrarVeiculo(VeiculoBase veiculo)
        {
            this.Veiculos.Add(veiculo);
        }

        public void RealizarLocacao(LocacaoBase locacao)
        {
            this.Locacoes.Add(locacao);
        }

        public List<PessoaBase> BuscarPessoas()
        {
            return this.Clientes.ToList();
        }

        public List<VeiculoBase> BuscarVeiculos()
        {
            return this.Veiculos.ToList();
        }
    }
}
