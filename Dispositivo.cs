namespace TesteDe;
// A classe abstrata Dispositivo serve como um molde genérico para todos os tipos de dispositivos.
// Ela encapsula características comuns, como ID, Nome, Ativo, e fornece um contrato básico para
// todos os dispositivos, garantindo consistência e permitindo tratamento uniforme de objetos de
// diferentes subclasses através do conceito de polimorfismo.

public abstract class Dispositivo{
    public int ID {get;}
    public string Nome {get ; set;}
    public bool Ativo {get ; set;}
// Listas em C# são coleções ordenadas de elementos do mesmo tipo.
// Elas permitem o armazenamento de zero ou mais elementos, que podem ser acessados por meio de um índice inteiro.
// As listas oferecem flexibilidade para adicionar, remover e modificar elementos dinamicamente durante a execução do programa.
// São amplamente utilizadas para armazenar conjuntos de dados que precisam ser acessados de forma sequencial.

    public List<DadosDispositivo> Dados {get;} = new List<DadosDispositivo>();
    public Gateway Gateway {get;}

// Construtor da classe Dispositivo
// Este construtor é acessível apenas por classes derivadas dentro da mesma hierarquia de herança
    protected Dispositivo ( int id, string nome, bool ativo, Gateway gateway){
        ID = id;
        Nome = nome;
        Ativo = ativo;
        Gateway = gateway;
    }

    public abstract void ColetarDados();
}
// Polimorfismo é demonstrado neste código através do método ColetarDados() na classe Dispositivo. 
// Todas as subclasses de Dispositivo, como Termometro e Higrometro, implementam esse método de forma 
// específica para cada tipo de dispositivo. Isso permite que o mesmo método seja chamado de maneira 
// uniforme em diferentes tipos de dispositivos, mas executado de forma diferente dependendo do tipo 
// de dispositivo ao qual ele se refere.

