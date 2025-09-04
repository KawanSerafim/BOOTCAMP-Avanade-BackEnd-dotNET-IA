using System.Text;

namespace desafios.Estacionamento.Models
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

        public void AdicionarVeiculo(string placa)
        {
            veiculos.Add(placa);
        }

        public string RemoverVeiculo(string placa, int horas)
        {
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                veiculos.Remove(placa);

                return $"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}";
            }
            else
            {
                return "\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente";
            }
        }

        public string ListarVeiculos()
        {
            if (veiculos.Any())
            {
                StringBuilder builder = new StringBuilder("Os veículos estacionados são:\n");

                foreach (string veiculo in veiculos)
                {
                    builder.Append(veiculo);
                    builder.Append("\n");
                }

                return builder.ToString();
            }
            else
            {
                return "Não há veículos estacionados.";
            }
        }
    }
}