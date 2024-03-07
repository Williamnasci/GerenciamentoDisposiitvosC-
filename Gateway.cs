using System;
using System.Collections.Generic;
// A biblioteca System.Collections.Generic fornece classes e interfaces genéricas que
// suportam coleções de dados, como listas, dicionários, conjuntos, entre outros.
// Essas coleções genéricas oferecem flexibilidade e desempenho ao trabalhar com coleções de diferentes tipos de objetos.

namespace TesteDe
{
    public class Gateway
    {
// O uso do modificador private para os campos dispositivos e proximoId na classe Gateway
// ajuda a promover uma melhor encapsulação, controle de acesso e abstração,
// melhorando assim a organização e manutenção do código.

        private List<Dispositivo> dispositivos = new List<Dispositivo>();
        private int proximoId = 1;

        public int ObterDispositivoId()
        {
            return proximoId++;
        }

        public void AdicionarDispositivo(Dispositivo dispositivo)
        {
            dispositivos.Add(dispositivo);
        }

        public void RemoverDispositivo(int id)
        {
            Dispositivo dispositivo = dispositivos.Find(d => d.ID == id);
            if (dispositivo != null)
                dispositivos.Remove(dispositivo);
        }

        public void ListarDispositivos()
        {
            foreach (var dispositivo in dispositivos)
            {
                Console.WriteLine($"ID: {dispositivo.ID}, Nome: {dispositivo.Nome}, Ativo: {dispositivo.Ativo}");
            }
        }
    }
}
