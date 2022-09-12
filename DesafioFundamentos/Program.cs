using DesafioFundamentos.Models;


Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");

string precoInicialStr = Console.ReadLine();
decimal.TryParse(precoInicialStr, out precoInicial);
if(precoInicialStr != "0" && precoInicial == 0)
{
    Console.WriteLine("Valor inválido!\n" + "O programa se encerrou");
    return;
}

Console.WriteLine("Agora digite o preço por hora:");
string precoPorHoraStr = Console.ReadLine();
decimal.TryParse(precoPorHoraStr, out precoPorHora);
if(precoPorHoraStr != "0" && precoPorHora == 0)
{
    Console.WriteLine("Valor inválido!\n" + "O programa se encerrou");
    return;
}

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
