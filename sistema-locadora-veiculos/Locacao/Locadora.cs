using sistema_locadora_veiculos.Locacao;
using sistema_locadora_veiculos.Pessoa.Pessoa;
using sistema_locadora_veiculos.Veiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_locadora_veiculos.Locacoes
{
    public class Locadora
    {
        public List<PessoaBase> Clientes { get; private set; }
        public List<VeiculoBase> Veiculos { get; private set; }
        public List<LocacaoBase> Locacoes { get; private set; }

        public Locadora()
        {
            this.Locacoes = new List<LocacaoBase>();
            this.Clientes = new List<PessoaBase>
        {
            new PessoaFisica(
                nome: "Ana Júlia Martins",
                cpf: "123.456.789-00",
                telefone: "(16) 98888-1111",
                endereco: new Endereco(
                    rua: "Rua das Flores",
                    numero: 120,
                    cidade: "Taquaritinga",
                    estado: "SP",
                    cep: "15900-000",
                    complemento: "Casa"
                )
            ),
            new PessoaFisica(
                nome: "Carlos Henrique",
                cpf: "987.654.321-00",
                telefone: "(16) 97777-2222",
                endereco: new Endereco(
                    rua: "Av. Brasil",
                    numero: 550,
                    cidade: "Araraquara",
                    estado: "SP",
                    cep: "14800-000",
                    complemento: "Apto 12B"
                )
            ),
            new PessoaJuridica(
                nome: "Tech Soluções LTDA",
                telefone: "(16) 3333-4444",
                endereco: new Endereco(
                    rua: "Rua do Comércio",
                    numero: 1000,
                    cidade: "Matão",
                    estado: "SP",
                    cep: "15990-000",
                    complemento: "Sala 3"
                ),
                cnpj: "12.345.678/0001-99"
            ),
            new PessoaJuridica(
                nome: "AgroVale Transportes ME",
                telefone: "(16) 3555-6666",
                endereco: new Endereco(
                    rua: "Rodovia SP-333",
                    numero: 5000,
                    cidade: "Itápolis",
                    estado: "SP",
                    cep: "14900-000",
                    complemento: null
                ),
                cnpj: "98.765.432/0001-11"
            )
        };
            this.Veiculos = new List<VeiculoBase>
        {
            new Carro(
                marca: "Toyota",
                modelo: "Corolla",
                ano: 2022,
                placa: "ABC1D23",
                categoria: "SEDAN",
                combustivel: "GASOLINA",
                cambio: "Automático",
                valorAluguel: 150
            ),
            new Carro(
                marca: "Fiat",
                modelo: "Pulse",
                ano: 2023,
                placa: "XYZ9Z99",
                categoria: "SUV",
                combustivel: "FLEX",
                cambio: "Manual",
                valorAluguel: 90
            ),
            new Carro(
                marca: "BMW",
                modelo: "M3",
                ano: 2021,
                placa: "BBB3B33",
                categoria: "ESPORTIVO",
                combustivel: "GASOLINA",
                cambio: "Automático",
                valorAluguel: 200
            ),

            new Moto(
                marca: "Honda",
                modelo: "CB 300R",
                ano: 2022,
                placa: "HND1A23",
                cilindrada: "300cc",
                combustivel: "GASOLINA",
                categoria: "NAKED",
                valorAluguel: 50
            ),
            new Moto(
                marca: "Yamaha",
                modelo: "MT-07",
                ano: 2021,
                placa: "YMH2B45",
                cilindrada: "700cc",
                combustivel: "GASOLINA",
                categoria: "ESPORTIVA",
                valorAluguel: 80
            ),
            new Moto(
                marca: "BMW",
                modelo: "R 1250 GS",
                ano: 2023,
                placa: "BMW1C23",
                cilindrada: "1250cc",
                combustivel: "GASOLINA",
                categoria: "BIG TRAIL",
                valorAluguel: 120
            ),

            new Caminhao(
                marca: "Mercedes-Benz",
                modelo: "Accelo 1016",
                ano: 2020,
                placa: "MBX1A10",
                capacidadeCarga: 6000.0,
                categoria: "VUC",
                combustivel: "DIESEL",
                valorAluguel: 400
            ),
            new Caminhao(
                marca: "Volvo",
                modelo: "FH 540",
                ano: 2023,
                placa: "VOL2B22",
                capacidadeCarga: 30000.0,
                categoria: "CAVALO MECÂNICO",
                combustivel: "DIESEL",
                valorAluguel: 700
            ),
            new Caminhao(
                marca: "Scania",
                modelo: "R 450",
                ano: 2022,
                placa: "SCN9C99",
                capacidadeCarga: 28000.0,
                categoria: "TRUCK",
                combustivel: "DIESEL",
                valorAluguel: 600
            )
        };
        }

        public void CadastrarCliente(PessoaBase pessoa)
        {
            this.Clientes.Add(pessoa);
        }
        public void CadastrarVeiculo(VeiculoBase veiculo)
        {
            this.Veiculos.Add(veiculo);
        }


        public void RealizarLocacao(LocacaoBase locacao)
        {
            this.Locacoes.Add(locacao);
        }
        public LocacaoBase FinalizarLocacao(DateOnly dataFim, int id)
        {
            LocacaoBase locacao = this.Locacoes.Find(locacao => locacao.Id == id);
            this.Locacoes.Remove(locacao);
            return locacao.FinalizarLocacao(dataFim, id);
        }

        public List<PessoaBase> BuscarClientes()
        {
            return this.Clientes.ToList();
        }
        public PessoaBase BuscarCliente(string? documento, int? id)
        {
            if (!String.IsNullOrEmpty(documento))
                return this.Clientes.Find((cliente) => cliente.Documento == documento);
            else
            {
                return this.Clientes.Find((cliente) => cliente.Id == id);
            }
        }

        public VeiculoBase BuscarVeiculoId(int id)
        {
            return this.Veiculos.Find(veiculo => veiculo.Id == id);
        }
        public List<VeiculoBase> BuscarVeiculosCategoria(string? categoria)
        {
            return this.Veiculos.FindAll(veiculo => veiculo.Categoria == categoria);
        }
        public List<VeiculoBase> BuscarVeiculosCombustivel(string? combustivel)
        {
            return this.Veiculos.FindAll(veiculo => veiculo.Combustivel == combustivel);
        }
        public VeiculoBase BuscarVeiculoPlaca(string? placa)
        {
            return this.Veiculos.Find(veiculo => veiculo.Placa == placa);
        }
        public List<VeiculoBase> BuscarVeiculos()
        {
            return this.Veiculos.ToList();
        }

        public List<LocacaoBase> BuscarLocacoes()
        {
            return this.Locacoes.ToList();
        }
    }
}
