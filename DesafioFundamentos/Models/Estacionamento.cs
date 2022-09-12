namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo.ToUpper());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placaVeiculo = Console.ReadLine().ToUpper();

            if (veiculos.Any(x => x == placaVeiculo))
            {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string horas = Console.ReadLine();
                int.TryParse(horas, out int horasInt);
            
                if(horasInt != 0 || horas == "0")
                {
                    decimal valorTotal = precoInicial + precoPorHora * horasInt;
                    
                    veiculos.Remove(placaVeiculo);

                    Console.WriteLine($"O veículo {placaVeiculo} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Formato de horas incorreto, tente digitar um número inteiro");
                }

                

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {veiculos[i]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
