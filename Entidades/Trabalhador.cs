using contratoDoTrabalhador.Entidades.Enums;
using ContratoDoTrabalhador.Entidades;
using System.Collections.Generic;


namespace contratoDoTrabalhador.Entidades {
    internal class Trabalhador {
        // Propriedade que armazena o nome do trabalhador
        public string Nome
        {
            get; set;
        }

        // Propriedade que armazena o nível do trabalhador (Junior/Pleno/Senior)
        public NivelDoTrabalhador Nivel
        {
            get; set;
        }

        // Propriedade que armazena o salário base do trabalhador
        public decimal SalarioBase
        {
            get; set;
        }

        // Propriedade que armazena o departamento do trabalhador
        public Departamento Departamento
        {
            get; set;
        }

        // Lista que armazena os contratos por hora do trabalhador
        public List<ContratoPorHora> Contratos { get; set; } = new List<ContratoPorHora>();

        // Construtor padrão, não é visível fora da classe
        Trabalhador()
        {
        }

        // Construtor que recebe os dados do trabalhador como parâmetros
        public Trabalhador(string nome, NivelDoTrabalhador nivel, decimal salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        // Método para adicionar um contrato à lista de contratos do trabalhador
        public void AdicionarContrato(ContratoPorHora contrato)
        {
            Contratos.Add(contrato);
        }

        // Método para remover um contrato da lista de contratos do trabalhador
        public void RemoverContrato(ContratoPorHora contrato)
        {
            Contratos.Remove(contrato);
        }

        // Método para calcular o rendimento do trabalhador em determinado mês e ano
        public decimal Rendimento(int mes, int ano)
        {
            decimal soma = SalarioBase;

            // Itera através dos contratos do trabalhador para somar os rendimentos do mês e ano fornecidos
            foreach (ContratoPorHora contrato in Contratos)
            {
                if (contrato.Data.Month == mes && contrato.Data.Year == ano)
                {
                    soma += contrato.valorTotal();
                }
            }

            return soma;
        }
    }
}


