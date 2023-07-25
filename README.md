**README - Programa de Contratos de Trabalhador**

Este é um programa simples para calcular o rendimento de trabalhadores com base em contratos de trabalho por hora. O programa permite que o usuário insira os dados de um trabalhador, incluindo seu nome, departamento, nível (Junior, Pleno ou Senior) e informações sobre os contratos de trabalho que ele possui. Em seguida, o usuário pode especificar o mês e o ano para calcular o rendimento total do trabalhador para esse período.

### Requisitos do Sistema

- Para executar este programa, você precisará de um ambiente de desenvolvimento C# compatível, como o Visual Studio ou o Visual Studio Code.

### Como Executar o Programa

1. Clone este repositório ou faça o download dos arquivos do programa.

2. Abra o projeto em um ambiente de desenvolvimento C#.

3. Execute o projeto para iniciar o programa.

### Como Utilizar o Programa

1. Quando o programa iniciar, você verá um prompt solicitando que você digite o nome do departamento.

2. Em seguida, você será solicitado a inserir os dados do trabalhador, incluindo o nome, nível (Junior, Pleno ou Senior) e o salário base.

3. Após inserir os dados do trabalhador, o programa pedirá que você insira a quantidade de contratos para esse trabalhador.

4. Para cada contrato, você precisará fornecer a data (no formato DD/MM/YYYY), o valor por hora e a duração do serviço em horas.

5. Após inserir todos os contratos, o programa pedirá que você insira o mês e o ano para o qual deseja calcular o rendimento do trabalhador.

6. O programa exibirá o nome e o departamento do trabalhador, bem como o rendimento total para o mês e ano fornecidos.

### Arquivos do Projeto

- `Program.cs`: Contém a função `Main` que é o ponto de entrada do programa e controla a interação com o usuário.

- `ContratoPorHora.cs`: Contém a classe `ContratoPorHora`, que representa um contrato de trabalho por hora e inclui informações como a data, valor por hora e horas trabalhadas.

- `Departamento.cs`: Contém a classe `Departamento`, que representa um departamento no contexto do programa e contém apenas o nome do departamento.

- `NivelDoTrabalhador.cs`: Contém a enumeração `NivelDoTrabalhador`, que representa os níveis possíveis de um trabalhador (Junior, Pleno e Senior).

### Contribuição

Este programa é livre e aberto para contribuições. Sinta-se à vontade para propor melhorias, correções de bugs ou adicionar novos recursos. Basta fazer um fork do repositório, criar uma branch para sua contribuição e enviar um pull request.

### Licença

Este programa é distribuído sob a licença MIT. Consulte o arquivo `LICENSE` para obter mais detalhes.

### Aviso

Este programa foi desenvolvido com fins educacionais e pode conter limitações ou não refletir todas as práticas recomendadas em um projeto de software de produção.

**Divirta-se e obrigado por usar o programa!**
