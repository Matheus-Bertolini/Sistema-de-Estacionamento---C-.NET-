using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita os preços iniciais ao usuário
        Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!\n");

        Console.Write("Digite o preço inicial: ");
        decimal precoInicial = decimal.Parse(Console.ReadLine());

        Console.Write("Digite o preço por hora: ");
        decimal precoPorHora = decimal.Parse(Console.ReadLine());

        // Cria uma instância do estacionamento
        Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

        // Menu principal
        string opcao = string.Empty;

        do
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    estacionamento.AdicionarVeiculo();
                    break;

                case "2":
                    estacionamento.RemoverVeiculo();
                    break;

                case "3":
                    estacionamento.ListarVeiculos();
                    break;

                case "4":
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            if (opcao != "4")
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcao != "4");
    }
}
