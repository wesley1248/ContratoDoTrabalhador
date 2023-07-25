using contratoDoTrabalhador.Entidades;
using contratoDoTrabalhador.Entidades.Enums;
using ContratoDoTrabalhador.Entidades;
using System;
using System.Globalization;


namespace ContratoDoTrabalhador {
    internal class Program {
        static void Main(string[] args)
        {
            // Solicita ao usuário que digite o nome do departamento
            Console.Write("Digite o nome do departamento: ");
            string auxiliarDepartamento = Console.ReadLine();

            // Solicita ao usuário que insira os dados do trabalhador
            Console.WriteLine("Insira os dados do trabalhador");
            Console.Write("Nome: ");
            string auxiliarNome = Console.ReadLine();

            // Solicita ao usuário que digite o nível do trabalhador (Junior/Pleno/Senior)
            Console.Write("Level (Junior/Pleno/Senior): ");
            string entradaDoNivel = Console.ReadLine();
            // Converte a entrada do usuário em um valor do tipo NivelDoTrabalhador (enum)
            NivelDoTrabalhador auxiliarNivel = (NivelDoTrabalhador)Enum.Parse(typeof(NivelDoTrabalhador), entradaDoNivel);

            // Solicita ao usuário que digite o salário base do trabalhador
            Console.Write("Salario base: ");
            decimal auxiliarSalarioBase = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Cria um novo objeto da classe Departamento utilizando o nome do departamento fornecido pelo usuário
            Departamento departamento = new Departamento(auxiliarDepartamento);

            // Cria um novo objeto da classe Trabalhador utilizando os dados fornecidos pelo usuário, incluindo o departamento criado anteriormente
            Trabalhador trabalhador = new Trabalhador(auxiliarNome, auxiliarNivel, auxiliarSalarioBase, departamento);

            // Solicita ao usuário que digite a quantidade de contratos para o trabalhador
            Console.Write("Quantos contratos para esse trabalhador?: ");
            int auxiliarQuantidadeDeContratos = int.Parse(Console.ReadLine());

            // Loop para solicitar os dados de cada contrato do trabalhador
            for (int i = 1; i <= auxiliarQuantidadeDeContratos; i++)
            {
                Console.WriteLine($"Digite os dados para o contrato #{i}");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime auxiliarData = DateTime.Parse(Console.ReadLine());

                Console.Write("Digite o valor por hora: ");
                decimal auxiliarValorPorHora = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Digite a duração do serviço (Horas): ");
                int auxiliarDuracaoDoServico = int.Parse(Console.ReadLine());

                // Cria um novo objeto da classe ContratoPorHora com os dados fornecidos pelo usuário
                ContratoPorHora contrato = new ContratoPorHora(auxiliarData, auxiliarValorPorHora, auxiliarDuracaoDoServico);

                // Adiciona o contrato ao trabalhador
                trabalhador.AdicionarContrato(contrato);
            }

            Console.WriteLine();
            // Solicita ao usuário que digite o mês e o ano para calcular o rendimento do trabalhador
            Console.Write("Entre com o mês e o ano para calcular o rendimento (MM/YYYY): ");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3, 4));

            // Exibe o nome e o departamento do trabalhador
            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);

            // Calcula e exibe o rendimento do trabalhador para o mês e ano fornecidos pelo usuário
            Console.WriteLine("Rendimento para a data " + mesEano + ": " + trabalhador.Rendimento(mes, ano).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}


