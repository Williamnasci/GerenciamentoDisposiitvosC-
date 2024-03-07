namespace TesteDe;

public class DadosDispositivo{
    public double Valor {get ; set;}
    public DateTime Timestamp {get ; set;}


// Aqui, dispositivo é uma instância da classe DadosDispositivo. 
//Ele possui suas próprias cópias das propriedades e métodos definidos na classe DadosDispositivo, 
//e pode ser manipulado independentemente de outras instâncias da mesma classe. 
//Cada instância tem seu próprio conjunto único de valores de propriedade, mas compartilha a mesma estrutura e comportamento definidos pela classe.

    public DadosDispositivo(DateTime timestamp, double valor){
// Construtor da classe, inicializa as propriedades Valor e Timestamp
        Timestamp = timestamp;
        Valor = valor;

// DadosDispositivo é o nome da classe e DadosDispositivo é o construtor.
// Ele aceita dois parâmetros, timestamp e valor, que são usados para inicializar as propriedades Timestamp e Valor do objeto DadosDispositivo que está sendo criado.
// O construtor é usado para garantir que um objeto DadosDispositivo seja criado com valores iniciais específicos.
       
    }
}
