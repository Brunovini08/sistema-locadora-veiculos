using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Pessoa.Pessoa
{
    public class Endereco
    {
        private string Rua { get; set; }
        private string Numero { get; set; }
        private string Cidade { get; set; }
        private string Estado { get; set; }
        private string CEP { get; set; }
        private string Complemento { get; set; }
        public Endereco(string rua, string numero, string cidade, string estado, string cep, string complemento)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
            Complemento = complemento;
        }
        public override string ToString()
        {
            return $"Rua: {Rua}, Número: {Numero}, Cidade: {Cidade}, Estado: {Estado}, CEP: {CEP}, {(Complemento != null ? $" Complemento: {Complemento}" : "")}";
        }
    }
}
