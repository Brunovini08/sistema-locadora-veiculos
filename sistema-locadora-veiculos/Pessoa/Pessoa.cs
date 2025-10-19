using sistema_locadora_veiculos.Pessoa.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Pessoa.Pessoa
{
    public abstract class Pessoa
    {
        private string Nome { get; set; }
        private string Telefone { get; set; }
        private Endereco EnderecoPessoa { get; set; }
        public Pessoa(string nome, string telefone, Endereco endereco)
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
