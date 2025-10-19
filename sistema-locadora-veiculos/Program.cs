using sistema_locadora_veiculos.Locacao;
using sistema_locadora_veiculos.Locacoes;
using sistema_locadora_veiculos.Pessoa.Pessoa;
using sistema_locadora_veiculos.Veiculo;
using System.Runtime.CompilerServices;

Locadora locadora = new Locadora();

void Menu()
{
    ExibirMenuInicial();
    Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    while (opcao != 0)
    {
        switch (opcao)
        {
            case 1:
                RealizarLocacao();
                break;
            case 2:
                break;
            case 3:
                Console.Clear();
                CadastrarVeiculo();
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                var veiculoEncontrado = BuscarVeiculos();
                if (veiculoEncontrado == null)
                {
                    Console.WriteLine("Nenhum Veículo encontrado");
                    Console.ReadKey();
                    break;
                }
                if (veiculoEncontrado.Count == 1)
                {
                    Console.WriteLine($"{veiculoEncontrado.Count} - VEÍCULO ENCONTRADO: ");
                }
                else
                {
                    Console.WriteLine($"{veiculoEncontrado.Count} - VEÍCULOS ENCONTRADOS: ");
                }
                foreach (var veiculo in veiculoEncontrado)
                {
                    Console.WriteLine(veiculo);
                }
                Console.ReadKey();
                break;
            case 5:
                Console.Clear();
                CadastrarCliente();
                break;
            case 6:
                Console.Clear();
                var clienteEncontrado = BuscarCliente();
                if (clienteEncontrado == null)
                {
                    Console.WriteLine("Nenhum Cliente encontrado com esse documento");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("CLIENTE ENCONTRADO: ");
                Console.WriteLine();
                Console.WriteLine(clienteEncontrado.ToString());
                Console.ReadKey();
                break;
            case 7:
                Console.Clear();
                var clientes = locadora.BuscarClientes();
                Console.WriteLine("CLIENTES ENCONTRADOS: ");
                foreach (var cliente in clientes)
                {
                    Console.WriteLine(cliente);
                }
                Console.ReadKey();
                break;
        }

        ExibirMenuInicial();
        Console.Write("Digite a opção desejada: ");
        opcao = int.Parse(Console.ReadLine());
    }
}


void RealizarLocacao()
{
    Console.Clear();
    Console.WriteLine("REALIZAR LOCAÇÃO DE UM VEÍCULO");
    var clientes = locadora.BuscarClientes();
    Console.WriteLine("CLIENTES ENCONTRADOS: ");
    foreach (var cliente in clientes)
    {
        Console.WriteLine(cliente);
    }
    Console.WriteLine();
    Console.WriteLine("Selecione o Cliente pelo ID: ");
    int idCliente = int.Parse(Console.ReadLine());
    var clienteEncontrado = locadora.BuscarCliente("", idCliente);
    Console.Clear();
    var veiculos = BuscarVeiculos();
    if (veiculos == null)
    {
        Console.WriteLine("Nenhum Veículo encontrado");
        Console.ReadKey();
    }
    if (veiculos.Count == 1)
    {
        Console.WriteLine($"{veiculos.Count} - VEÍCULO ENCONTRADO: ");
    }
    else
    {
        Console.WriteLine($"{veiculos.Count} - VEÍCULOS ENCONTRADOS: ");
    }
    foreach (var veiculo in veiculos)
    {
        Console.WriteLine(veiculo);
    }
    Console.WriteLine();
    Console.WriteLine("Selecione o Veículo desejado: ");
    int idVeiculo = int.Parse(Console.ReadLine());

    var veiculoEncontrado = locadora.BuscarVeiculoId(idVeiculo);
    Console.Clear();

    LocacaoBase locacao = new LocacaoBase(clienteEncontrado, veiculoEncontrado);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Locação realizado com sucesso!");
    Console.ResetColor();
    Console.WriteLine("");
    Console.WriteLine(locacao.ToString());
    Console.ReadKey();
}
 
//Cadastrar Veiculo
void CadastrarVeiculo()
{
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Categoria Veículo              ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ 1. CARRO                                   ║");
    Console.WriteLine("║ 2. MOTO                                    ║");
    Console.WriteLine("║ 3. CAMINHÃO                                ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
    Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            VeiculoBase carro = CadastrarCarro();
            locadora.CadastrarVeiculo(carro);
            break;
        case 2:
            VeiculoBase moto = CadastrarMoto();
            locadora.CadastrarVeiculo(moto);
            break;

        case 3:
            VeiculoBase caminhao = CadastrarCaminhao();
            locadora.CadastrarVeiculo(caminhao);
            break;
    }
}
VeiculoBase CadastrarCarro()
{
    Console.Clear();
    Console.Write("Digite a marca do carro: ");
    string marca = Console.ReadLine();
    Console.Clear();
    Console.Write("Digite o modelo do carro: ");
    string modelo = Console.ReadLine();
    Console.Clear();
    Console.Write("Digite o ano do carro: ");
    int ano = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.Write("Digite a placa do veículo (ABC-123): ");
    string placa = Console.ReadLine();
    CategoriaCarro();
    Console.Write("Digite a categoria do carro: ");
    string opcaoCategoria = Console.ReadLine().ToUpper();
    CombustivelCarro();
    Console.Write("Digite o tipo de combustível do carro: ");
    string opcaoCombustivel = Console.ReadLine().ToUpper();
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║               Tipo de Câmbio               ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ AUTOMÁTICO                                 ║");
    Console.WriteLine("║ MANUAL                                     ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
    Console.Write("Digite o tipo de combustível do carro: ");
    string opcaoCambio = Console.ReadLine().ToUpper();
    VeiculoBase carro = new Carro(marca, modelo, ano, placa, opcaoCategoria, opcaoCombustivel, opcaoCambio);
    Console.Clear();
    return carro;
}
VeiculoBase CadastrarMoto()
{
    Console.Clear();
    Console.Write("Digite a marca do moto: ");
    string marca = Console.ReadLine();
    Console.Clear();
    Console.Write("Digite o modelo do moto: ");
    string modelo = Console.ReadLine();
    Console.Clear();
    Console.Write("Digite o ano do moto: ");
    int ano = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.Write("Digite a placa do veículo (ABC1234): ");
    string placa = Console.ReadLine();

    if (placa.Length != 7)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("A placa deve conter 7 dígitos");
        Console.WriteLine("");
        Console.ResetColor();
        Console.Write("Digite a placa do veículo (ABC1234): ");
        placa = Console.ReadLine();
    }
    CategoriaMoto();
    Console.Write("Digite a categoria da moto: ");
    string opcaoCategoria = Console.ReadLine().ToUpper();
    CilindradasMoto();
    Console.Write("Digite a cilindrada da moto: ");
    string opcaoCilindradas = Console.ReadLine().ToLower();
    CombustivelMoto();
    Console.Write("Digite o tipo de combustível da moto: ");
    string opcaoCombustivel = Console.ReadLine().ToUpper();
    Console.Clear();
    VeiculoBase moto = new Moto(marca, modelo, ano, placa, opcaoCilindradas, opcaoCombustivel, opcaoCategoria);
    return moto;
}
VeiculoBase CadastrarCaminhao()
{
    Console.Clear();
    Console.Write("Digite a marca do caminhão: ");
    string marca = Console.ReadLine();
    Console.Clear();
    Console.Write("Digite o modelo do caminhão: ");
    string modelo = Console.ReadLine();
    Console.Clear();
    Console.Write("Digite o ano do caminhão: ");
    int ano = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.Write("Digite a placa do veículo (ABC1234): ");
    string placa = Console.ReadLine();
    if (placa.Length != 7)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("A placa deve conter 7 dígitos");
        Console.WriteLine("");
        Console.ResetColor();
        Console.Write("Digite a placa do veículo (ABC1234): ");
        placa = Console.ReadLine();
    }
    Console.Clear();
    Console.Write("Digite a capacidade do caminhão em KG: ");
    double capacidade = double.Parse(Console.ReadLine());
    CategoriaCaminhao();
    Console.Write("Digite a categoria da caminhão: ");
    string opcaoCategoria = Console.ReadLine().ToUpper();
    CombustivelCaminhao();
    Console.Write("Digite o tipo de combustível do caminhão: ");
    string opcaoCombustivel = Console.ReadLine().ToUpper();
    Console.Clear();
    VeiculoBase caminhao = new Caminhao(marca, modelo, ano, placa, capacidade, opcaoCombustivel, opcaoCategoria);
    Console.Clear();
    return caminhao;
}


//Cadastrar Clientes
void CadastrarCliente()
{
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Tipo de Cliente                ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ 1. Pessoa Física                           ║");
    Console.WriteLine("║ 2. Pessoa Jurídica                         ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
    Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            PessoaBase pessoaFisica = CadastrarPessoaFisica();
            locadora.CadastrarCliente(pessoaFisica);
            break;
        case 2:
            PessoaBase pessoaJuridica = CadastrarPessoaJuridica();
            locadora.CadastrarCliente(pessoaJuridica);
            break;
    }
}
PessoaBase CadastrarPessoaFisica()
{
    Console.Clear();
    Console.Write("Digite seu nome: ");
    string nome = Console.ReadLine();
    Console.Clear();

    Console.Write("Digite seu cpf: ");
    string cpf = Console.ReadLine();
    if (cpf.Length != 11)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("CPF inválido, o CPF deve conter 11 dígitos");
        Console.Write("Digite seu cpf: ");
        cpf = Console.ReadLine();
    }

    Console.Clear();
    Console.Write("Digite seu número de telefone: ");
    string numeroTelefone = Console.ReadLine();

    Console.Clear();
    Console.WriteLine("=== Cadastro de Endereço ===");
    Console.WriteLine();
    Console.Write("Digite a sua rua: ");
    string rua = Console.ReadLine();

    Console.Clear();
    Console.Write("Digite seu bairro: ");
    string bairro = Console.ReadLine();

    Console.Clear();
    Console.Write("Digite seu CEP: ");
    string cep = Console.ReadLine();
    if (cep.Length != 8)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("CEP inválido, o cep deve conter 8 caracters");
        Console.ResetColor();
        Console.WriteLine();
        Console.Write("Digite seu CEP: ");
        cep = Console.ReadLine();
    }

    Console.Clear();
    Console.Write("Digite seu número: ");
    int numero = int.Parse(Console.ReadLine());

    Console.Clear();
    Console.Write("Digite sua cidade: ");
    string cidade = Console.ReadLine();

    Console.Clear();
    Console.Write("Digite seu estado: ");
    string estado = Console.ReadLine();

    Console.Clear();
    Console.Write("Digite um complemento - (Opcional): ");
    string complemento = Console.ReadLine() ?? "";
    Endereco endereco = new Endereco(rua, numero, cidade, estado, cep, complemento);
    Console.Clear();

    PessoaBase pessoa = new PessoaFisica(nome, cpf, numeroTelefone, endereco);
    return pessoa;
}
PessoaBase CadastrarPessoaJuridica()
{
    Console.Clear();
    Console.Write("Digite seu nome: ");
    string nome = Console.ReadLine();
    Console.Clear();

    Console.Write("Digite seu cnpj: ");
    string cnpj = Console.ReadLine();
    if (cnpj.Length != 14)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("CNPJ inválido, o CNPJ deve conter 14 dígitos");
        Console.Write("Digite seu cpf: ");
        cnpj = Console.ReadLine();
    }

    Console.Clear();
    Console.Write("Digite seu número de telefone: ");
    string numeroTelefone = Console.ReadLine();

    Console.Clear();
    Console.WriteLine("=== Cadastro de Endereço ===");
    Console.WriteLine();
    Console.Write("Digite a sua rua: ");
    string rua = Console.ReadLine();

    Console.Clear();
    Console.Write("Digite seu bairro: ");
    string bairro = Console.ReadLine();

    Console.Clear();
    Console.Write("Digite seu CEP: ");
    string cep = Console.ReadLine();
    if (cep.Length != 8)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("CEP inválido, o cep deve conter 8 caracters");
        Console.ResetColor();
        Console.WriteLine();
        Console.Write("Digite seu CEP: ");
        cep = Console.ReadLine();
    }

    Console.Clear();
    Console.Write("Digite seu número: ");
    int numero = int.Parse(Console.ReadLine());

    Console.Clear();
    Console.Write("Digite sua cidade: ");
    string cidade = Console.ReadLine();

    Console.Clear();
    Console.Write("Digite seu estado: ");
    string estado = Console.ReadLine();

    Console.Clear();
    Console.Write("Digite um complemento - (Opcional): ");
    string complemento = Console.ReadLine() ?? "";
    Endereco endereco = new Endereco(rua, numero, cidade, estado, cep, complemento);
    Console.Clear();

    PessoaBase pessoa = new PessoaJuridica(nome, numeroTelefone, endereco, cnpj);
    return pessoa;
}

//Buscar Cliente
PessoaBase BuscarCliente()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║               Buscar Cliente               ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ 1. Pessoa Física                           ║");
    Console.WriteLine("║ 2. Pessoa Jurídica                         ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
    Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1: return BuscarPessoaFisica();
        case 2: return BuscarPessoaJuridica();
    }

    return null;
}

PessoaBase BuscarPessoaFisica()
{
    Console.Write("Digite seu CPF sem pontos: ");
    string cpf = Console.ReadLine();

    return locadora.BuscarCliente(cpf, 0);
}

PessoaBase BuscarPessoaJuridica()
{
    Console.Write("Digite seu CNPJ com pontos: ");
    string cnpj = Console.ReadLine();

    return locadora.BuscarCliente(cnpj, 0);
}

//Buscar Veiculos
List<VeiculoBase> BuscarVeiculos()
{
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║               Buscar Veiculos              ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ 1. Carro                                   ║");
    Console.WriteLine("║ 2. Moto                                    ║");
    Console.WriteLine("║ 3. Caminhão                                ║");
    Console.WriteLine("║ 4. Todos os Veículos                       ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
    Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            return BuscarCarros();
        case 2:
            return BuscarMotos();
        case 3:
            return BuscarCaminhoes();
        case 4:
            return locadora.BuscarVeiculos();
    }

    return null;
}
List<VeiculoBase> BuscarCarros()
{
    BuscarVeiculo("Carros");
    Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            return BuscarPorCatetoria("CAR");
        case 2:
            return BuscarPorCombustivel("CAR");
    }

    return null;
}
List<VeiculoBase> BuscarMotos()
{
    BuscarVeiculo("Motos");
    Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            return BuscarPorCatetoria("MOTO");
        case 2:
            return BuscarPorCombustivel("MOTO");
    }

    return null;
}
List<VeiculoBase> BuscarCaminhoes()

{
    BuscarVeiculo("Caminhões");
    Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            return BuscarPorCatetoria("CAM");
        case 2:
            return BuscarPorCombustivel("CAM");
    }

    return null;
}

List<VeiculoBase> BuscarPorCatetoria(string veiculo)
{
    switch (veiculo)
    {
        case "CAR": CategoriaCarro(); break;
        case "MOTO": CategoriaMoto(); break;
        case "CAM": CategoriaCaminhao(); break;
    }
    Console.Write("Digite a categoria do carro: ");
    string opcaoCategoria = Console.ReadLine().ToUpper();

    var veiculoEncontrado = locadora.BuscarVeiculosCategoria(opcaoCategoria);

    if (veiculoEncontrado == null)
        return null;
    return veiculoEncontrado;

}
List<VeiculoBase> BuscarPorCombustivel(string veiculo)
{
    switch (veiculo)
    {
        case "CAR": CombustivelCarro(); break;
        case "MOTO": CombustivelMoto(); break;
        case "CAM": CombustivelCaminhao(); break;
    }
    Console.Write("Digite o tipo de combustível do carro: ");
    string opcaoCombustivel = Console.ReadLine().ToUpper();

    return locadora.BuscarVeiculosCombustivel(opcaoCombustivel);
}


//Exibição de Menus

//Carro
void CategoriaCarro()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Categoria do Carro             ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ HEAT                                       ║");
    Console.WriteLine("║ SEDAN                                      ║");
    Console.WriteLine("║ SUV                                        ║");
    Console.WriteLine("║ LUXO                                       ║");
    Console.WriteLine("║ ESPORTIVO                                  ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
}
void CombustivelCarro()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Tipo de Combustível            ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ GASOLINA                                   ║");
    Console.WriteLine("║ ALCOÓL                                     ║");
    Console.WriteLine("║ DIESEL                                     ║");
    Console.WriteLine("║ ELETRICO                                   ║");
    Console.WriteLine("║ HÍBRIDO                                    ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
}

//Moto
void CategoriaMoto()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Categoria da Moto              ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ STREET                                     ║");
    Console.WriteLine("║ NAKED                                      ║");
    Console.WriteLine("║ ESPORTIVA                                  ║");
    Console.WriteLine("║ TRAIL                                      ║");
    Console.WriteLine("║ BIG TRAIL                                  ║");
    Console.WriteLine("║ TOURING                                    ║");
    Console.WriteLine("║ CUSTOM                                     ║");
    Console.WriteLine("║ SCOOTER                                    ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
}
void CilindradasMoto()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Cilindradas da Moto            ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ 125cc                                      ║");
    Console.WriteLine("║ 150cc                                      ║");
    Console.WriteLine("║ 160cc                                      ║");
    Console.WriteLine("║ 250cc                                      ║");
    Console.WriteLine("║ 300cc                                      ║");
    Console.WriteLine("║ 400cc                                      ║");
    Console.WriteLine("║ 500cc                                      ║");
    Console.WriteLine("║ 600cc                                      ║");
    Console.WriteLine("║ 700cc                                      ║");
    Console.WriteLine("║ 800cc                                      ║");
    Console.WriteLine("║ 900cc                                      ║");
    Console.WriteLine("║ 1000cc                                     ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
}
void CombustivelMoto()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Tipo de Combustível            ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ GASOLINA                                   ║");
    Console.WriteLine("║ ALCOÓL                                     ║");
    Console.WriteLine("║ ELETRICO                                   ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
}

//Caminhão
void CategoriaCaminhao()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Categoria do Caminhão          ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ VUC(Veículo Urbano de Carga)               ║");
    Console.WriteLine("║ TOCO                                       ║");
    Console.WriteLine("║ TRUCK                                      ║");
    Console.WriteLine("║ BITTRUCK                                   ║");
    Console.WriteLine("║ CAVALO MECÂNICO                            ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
}
void CombustivelCaminhao()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Tipo de Combustível            ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ GASOLINA                                   ║");
    Console.WriteLine("║ ALCOÓL                                     ║");
    Console.WriteLine("║ ELETRICO                                   ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
}
void ExibirMenuInicial()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║       Sistema de Locação de Veículos       ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ 1. Alugar veículo                          ║");
    Console.WriteLine("║ 2. Devolver veículo                        ║");
    Console.WriteLine("║ 3. Cadastrar veiculo                       ║");
    Console.WriteLine("║ 4. Listar veículos disponíveis             ║");
    Console.WriteLine("║ 5. Cadastrar Cliente                       ║");
    Console.WriteLine("║ 6. Buscar Cliente                          ║");
    Console.WriteLine("║ 7. Listar Clientes                         ║");
    Console.WriteLine("║ 8. Listar Locações                         ║");
    Console.WriteLine("║ 0. Sair                                    ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
}

void BuscarVeiculo(string veiculo)
{
    Console.Clear();
    Console.WriteLine(" ╔════════════════════════════════════════════╗");
    Console.WriteLine($"║               Buscar {veiculo}             ║");
    Console.WriteLine(" ╠════════════════════════════════════════════╣");
    Console.WriteLine(" ║ 1. Categoria                               ║");
    Console.WriteLine(" ║ 2. Combustivel                             ║");
    Console.WriteLine(" ╚════════════════════════════════════════════╝");
    Console.WriteLine();
}

Menu();
