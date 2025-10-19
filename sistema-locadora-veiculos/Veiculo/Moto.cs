using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Veiculo
{
    public class Moto : VeiculoBase
    {
        public string Cilindrada {  get; private set; }
        public Moto(string marca, string modelo, int ano, string placa, string cilindrada, string combustivel, string categoria) : base(marca, modelo, ano, placa, categoria, combustivel)
        {
            this.Cilindrada = cilindrada;
        }
    }
}
