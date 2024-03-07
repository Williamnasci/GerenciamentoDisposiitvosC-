# Sistema de Gerenciamento de Dispositivos em C#

Este é um sistema simples desenvolvido em C# para gerenciar dispositivos através de um gateway. Ele permite o cadastro de dispositivos, armazenamento de dados referentes a cada dispositivo e configurações específicas para cada tipo de dispositivo.

## Requisitos

- Visual Studio (ou qualquer IDE que suporte C#)

## Funcionalidades

- Adicionar dispositivos ao gateway
- Remover dispositivos do gateway
- Listar dispositivos no gateway
- Coletar dados de um dispositivo específico

## Como usar

1. Clone este repositório ou faça o download dos arquivos.
2. Abra o projeto no Visual Studio.
3. Compile e execute o programa.
4. Siga as instruções no menu interativo para usar as funcionalidades do sistema.

## Estrutura do Projeto

- **Program.cs**: Contém o código principal do programa, incluindo o menu interativo e a lógica principal.
- **Dispositivo.cs**: Define a classe abstrata `Dispositivo` e a classe `DadosDoDispositivo`.
- **Gateway.cs**: Define a classe `Gateway` para gerenciar os dispositivos.
- **Termometro.cs**: Define a subclasse `Termometro` de `Dispositivo`.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para enviar pull requests ou abrir issues relatando problemas ou sugestões.

## Autor

Este projeto foi desenvolvido por William Nascimento.
