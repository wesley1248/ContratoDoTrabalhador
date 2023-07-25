
namespace ContratoDoTrabalhador.Entidades {
    internal class Departamento {
        // Propriedade que armazena o nome do departamento
        public string Nome
        {
            get; set;
        }

        // Construtor padrão, não é visível fora da classe
        public Departamento()
        {
        }

        // Construtor que recebe o nome do departamento como parâmetro
        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}
