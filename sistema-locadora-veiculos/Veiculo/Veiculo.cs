using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Veiculo
{
    public abstract class Veiculo
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private int Ano { get; set; }
        private string Placa { get; set; }

        private List<Veiculo> Veiculos { get; set; }
        public Veiculo(string marca, string modelo, int ano, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Placa = placa;
            this.Veiculos = new List<Veiculo>();
        }
        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Placa: {Placa}";
        }

        public Veiculo CadastrarVeiculo(Veiculo veiculo)
        {
            this.Veiculos.Add(veiculo);
            return this;
        }
    }
}
