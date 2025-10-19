using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Veiculo
{
    public class Caminhao : VeiculoBase
    {
        private double CapacidadeCarga { get; set; }
        public Caminhao(string marca, string modelo, int ano, string placa, double capacidadeCarga, string categoria, string combustivel) : base(marca, modelo, ano, placa, categoria, combustivel)
        {
            CapacidadeCarga = capacidadeCarga;
        }

        public override string ToString()
        {
            return base.ToString() + $"Capacidade:   {CapacidadeCarga} kg\n";
        }
    }
}
