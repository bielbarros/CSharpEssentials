using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models.Estacionamento
{

    public class Estacionamento
    {
        public string placa { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataSaida { get; set; }
        public double valorHora { get; set; }
        public double valorTotal { get; set; }

        public Estacionamento(string placa, DateTime dataEntrada, DateTime dataSaida, double valorHora, double valorTotal)
        {
            this.placa = placa;
            this.dataEntrada = dataEntrada;
            this.dataSaida = dataSaida;
            this.valorHora = valorHora;
            this.valorTotal = valorTotal;

        }

        public void CalcularValorTotal()
        {
            TimeSpan tempoPermanencia = dataSaida - dataEntrada;
            double valorTotal = tempoPermanencia.TotalHours * valorHora;
            this.valorTotal = valorTotal;
            Console.WriteLine($"O valor total do estacionamento é: {valorTotal}");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Data de entrada: {dataEntrada}");
            Console.WriteLine($"Data de saída: {dataSaida}");
            Console.WriteLine($"Valor por hora: {valorHora}");
            Console.WriteLine($"Valor total: {valorTotal}");
        }


    }

}