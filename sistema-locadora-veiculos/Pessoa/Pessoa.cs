using sistema_locadora_veiculos.Pessoa.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sistema_locadora_veiculos.Pessoa.Pessoa
{
    public abstract class PessoaBase
    {
        private static int contador { get; set; } = 1;
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Documento { get; set; }
        public Endereco EnderecoPessoa { get; private set; }
        public PessoaBase(string nome, string telefone, Endereco endereco, string documento)
        {
            this.Id = contador++;
            this.Nome = nome;
            this.Telefone = telefone;
            this.EnderecoPessoa = endereco;
            this.Documento = documento;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"ID:          {Id}");
            sb.AppendLine($"Nome:        {Nome}");
            sb.AppendLine($"Telefone:    {Telefone}");
            return sb.ToString();
        }


    }
}
