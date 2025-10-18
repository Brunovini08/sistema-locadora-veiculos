using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Pessoa
{
    public abstract class Pessoa
    {
        private string Nome { get; set; }
        private string Telefone { get; set; }
        public Pessoa(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}";
        }
    }
}
