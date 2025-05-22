class Estacionamento
{
    public decimal precoInicial;
    public decimal precoPorHora;

    public List<string> veiculos;

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;

        veiculos = new List<string>();
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Informe a placa do veiculo: ");
        string veiculo = Console.ReadLine();
        veiculos.Add(veiculo);
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Informe a placa do veiculo estacionado: ");
        string veiculoEstacionado = Console.ReadLine();

        if (veiculos.Contains(veiculoEstacionado))
        {
            Console.WriteLine("Horas totais: ");
            int horaTotal = int.Parse(Console.ReadLine());

            decimal valorTotal = precoInicial + (precoPorHora * horaTotal);

            veiculos.Remove(veiculoEstacionado);
            Console.WriteLine($"O veiculo {veiculoEstacionado} foi removido e o preco total foi de R${valorTotal}");
        }
        else
        {
            Console.WriteLine("Placa do veiculo não foi encontrada.");
        }
    }

    public void ListarVeiculos()
    {
        Console.WriteLine("Lista de veiculos estacionados:");
        foreach (string veiculo in veiculos)
        {
            Console.WriteLine($"- {veiculo}");
        }
    }
}