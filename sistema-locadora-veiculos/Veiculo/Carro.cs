using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Veiculo
{
    public class Carro : VeiculoBase
    {
        public string Cambio { get; private set; }
        public Carro(string marca, string modelo, int ano, string placa, string categoria, string combustivel, string cambio) : base(marca, modelo, ano, placa, categoria, combustivel)
        {
            this.Cambio = cambio;
        }

        public override string ToString()
        {
            return base.ToString() + $"Câmbio:       {Cambio}\n";
        }
    }
}
