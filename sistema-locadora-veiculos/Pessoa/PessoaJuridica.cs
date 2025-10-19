using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Pessoa.Pessoa
{
    public class PessoaJuridica : PessoaBase
    {
        public string Cnpj { get; set; }
        public PessoaJuridica(string nome, string telefone, Endereco endereco, string cnpj) : base(nome, telefone, endereco)
        {
            Cnpj = cnpj;
        }

        public override string ToString()
        {
            return base.ToString() + $" CNPJ: {this.Cnpj}";
        }
    }
}
