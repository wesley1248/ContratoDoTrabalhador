using System;

namespace contratoDoTrabalhador.Entidades {
    internal class ContratoPorHora {
        // Propriedade que armazena a data do contrato
        public DateTime Data
        {
            get; set;
        }

        // Propriedade que armazena o valor por hora do contrato
        public decimal ValorPorHora
        {
            get; set;
        }

        // Propriedade que armazena a quantidade de horas do contrato
        public int Horas
        {
            get; set;
        }

        // Construtor padrão, não é visível fora da classe
        public ContratoPorHora()
        {
        }

        // Construtor que recebe a data, valor por hora e horas do contrato como parâmetros
        public ContratoPorHora(DateTime data, decimal valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        // Método que calcula o valor total do contrato (valor por hora * horas)
        public decimal valorTotal()
        {
            decimal resultado = ValorPorHora * Horas;
            return resultado;
        }
    }
}

