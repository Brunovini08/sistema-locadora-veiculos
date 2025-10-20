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
        public Moto(string marca, string modelo, int ano, string placa, string cilindrada, string combustivel, string categoria, double valorAluguel) : base(marca, modelo, ano, placa, categoria, combustivel, valorAluguel)
        {
            this.Cilindrada = cilindrada;
        }

        public override string ToString()
        {
            return base.ToString() + $"Cilindrada:   {Cilindrada}\n";
        }
    }
}
