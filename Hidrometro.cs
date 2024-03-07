namespace TesteDe;

public class Higrometro : Dispositivo{
  public Higrometro(int id, string nome, bool ativo, Gateway gateway) : base(id, nome, ativo, gateway){
      }

// Método ColetarDados() é sobrescrito na classe Higrometro para fornecer uma implementação específica de coleta de dados para higrômetros.
// Isso permite que cada tipo de dispositivo tenha seu próprio comportamento de coleta de dados, mantendo a consistência com o contrato definido pela classe base Dispositivo.

    public override void ColetarDados(){
        Random rand = new Random();
        double pressao = rand.Next(0,100);
        Dados.Add(new DadosDispositivo(DateTime.Now, pressao));  
    }
}