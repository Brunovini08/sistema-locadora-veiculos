using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Veiculo
{
    public class Moto : Veiculo
    {
        private List<string> Cilindrada = new List<string> { "125cc", "150cc", "160cc", "250cc", "300cc", "400cc", "500cc", "600cc", "700cc", "800cc", "900cc", "1000cc"};
        public Moto(string marca, string modelo, int ano, string placa, List<string> cilindrada) : base(marca, modelo, ano, placa)
        {
            Cilindrada = cilindrada;
        }
    }
}
