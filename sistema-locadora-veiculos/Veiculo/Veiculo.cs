using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Veiculo
{
    public abstract class VeiculoBase
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public string Placa { get; private set; }
        public string Categoria { get; private set; }
        public string Combustivel { get; private set; }
        public VeiculoBase(string marca, string modelo, int ano, string placa, string categoria, string combustivel)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Placa = placa;
            this.Categoria = categoria;
            this.Combustivel = combustivel;
        }
        public override string ToString()
        {
            return $"Marca: {this.Marca}, Modelo: {this.Modelo}, Ano: {this.Ano}, Placa: {this.Placa}, Categoria: {this.Categoria}";
        }
    }
}
