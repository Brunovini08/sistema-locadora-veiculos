using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Veiculo
{
    public class Carro : Veiculo
    {
        private List<string> Categoria = new List<string> { "Econômico", "Intermediário", "SUV", "Luxo" };
        private List<string> Combustivel = new List<string> { "Gasolina", "Álcool", "Diesel", "Elétrico", "Híbrido" };
        private List<string> Cambio = new List<string> { "Manual", "Automático" };
        public Carro(string marca, string modelo, int ano, string placa, List<string> categoria, List<string> combustivel, List<string> cambio) : base(marca, modelo, ano, placa)
        {
            Categoria = categoria;
            Combustivel = combustivel;
            Cambio = cambio;
        }
    }
}
