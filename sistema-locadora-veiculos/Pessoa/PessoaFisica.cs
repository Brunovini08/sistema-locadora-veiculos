using sistema_locadora_veiculos.Pessoa.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Pessoa.Pessoa
{
    public class PessoaFisica : PessoaBase
    {
        private string Cpf { get; set; }
        public PessoaFisica(string nome, string cpf, string telefone, Endereco endereco) : base(nome, telefone, endereco)
        {
            Cpf = cpf;
        }

        public override string ToString()
        {
            return base.ToString() + $"CPF: {this.Cpf}";
        }
    }
}
