using sistema_locadora_veiculos.Pessoa.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Pessoa.Pessoa
{
    public abstract class PessoaBase
    {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public Endereco EnderecoPessoa { get; private set; }
        public PessoaBase(string nome, string telefone, Endereco endereco)
        {
            Nome = nome;
            Telefone = telefone;
            EnderecoPessoa = endereco;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}";
        }

    }
}
