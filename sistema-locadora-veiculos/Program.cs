using sistema_locadora_veiculos.Locacoes;
using sistema_locadora_veiculos.Veiculo;

Locadora locadora = new Locadora();

void Menu()
{
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
    Console.WriteLine("║ 0. Sair                                    ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
    Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());

    while (opcao != 0)
    {
        switch (opcao)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                Console.Clear();
                CadastrarVeiculo();
                break;
            case 4:
                Console.Clear();
                var veiculos = locadora.BuscarVeiculos();
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
        }

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
        Console.WriteLine("║ 0. Sair                                    ║");
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.Write("Digite a opção desejada: ");
        opcao = int.Parse(Console.ReadLine());
    }
}

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
    Console.Write("Digite a categoria do carro: ");
    string opcaoCategoria = Console.ReadLine().ToUpper();
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
    Console.Write("Digite a categoria da moto: ");
    string opcaoCategoria = Console.ReadLine().ToUpper();
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
    Console.WriteLine("║ 1000cc                                      ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.Write("Digite a categoria da moto: ");
    string opcaoCilindradas = Console.ReadLine().ToLower();
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Tipo de Combustível            ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ GASOLINA                                   ║");
    Console.WriteLine("║ ALCOÓL                                     ║");
    Console.WriteLine("║ ELETRICO                                   ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
    Console.Write("Digite o tipo de combustível da moto: ");
    string opcaoCombustivel = Console.ReadLine().ToUpper();
    Console.Clear();
    VeiculoBase moto = new Moto(marca, modelo, ano, placa, opcaoCilindradas, opcaoCombustivel, opcaoCategoria);
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Categoria da Moto              ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ VUC(Veículo Urbano de Carga)               ║");
    Console.WriteLine("║ TOCO                                       ║");
    Console.WriteLine("║ TRUCK                                      ║");
    Console.WriteLine("║ BITTRUCK                                   ║");
    Console.WriteLine("║ CAVALO MECÂNICO                            ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
    Console.Write("Digite a categoria da caminhão: ");
    string opcaoCategoria = Console.ReadLine().ToUpper();
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════╗");
    Console.WriteLine("║             Tipo de Combustível            ║");
    Console.WriteLine("╠════════════════════════════════════════════╣");
    Console.WriteLine("║ GASOLINA                                   ║");
    Console.WriteLine("║ ALCOÓL                                     ║");
    Console.WriteLine("║ ELETRICO                                   ║");
    Console.WriteLine("╚════════════════════════════════════════════╝");
    Console.WriteLine();
    Console.Write("Digite o tipo de combustível do caminhão: ");
    string opcaoCombustivel = Console.ReadLine().ToUpper();
    Console.Clear();
    VeiculoBase caminhao = new Caminhao(marca, modelo, ano, placa, capacidade, opcaoCombustivel, opcaoCategoria);
    Console.Clear();
    return caminhao;
}

Menu();
