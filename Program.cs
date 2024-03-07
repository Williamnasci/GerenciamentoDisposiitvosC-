using System;

namespace TesteDe
{
    class Program
    {
        static void Main(string[] args)
        {
            Gateway gateway = new Gateway();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Adicionar: ");
                Console.WriteLine("2 - Remover: ");
                Console.WriteLine("3 - Listar: ");
                Console.WriteLine("4 - Sair: ");
                Console.Write("Escolha alguma opção: ");

                string opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        Console.Write("Digite o nome do dispositivo: ");
                        string nomeDispositivo = Console.ReadLine();
                        Console.Write("O dispositivo está ativo? (true/false): ");
                        if (bool.TryParse(Console.ReadLine(), out bool ativo))
                        {
                            int dispositivoId = gateway.ObterDispositivoId();
                            Dispositivo termometro = new Termometro(dispositivoId, nomeDispositivo, ativo, gateway);
                            gateway.AdicionarDispositivo(termometro);
                            Console.WriteLine("Dispositivo adicionado.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida para 'ativo'.");
                        }
                        break;

                    case "2":
                        Console.Write("Digite o Id a ser removido: ");
                        if (int.TryParse(Console.ReadLine(), out int idRemover))
                        {
                            gateway.RemoverDispositivo(idRemover);
                            Console.WriteLine("Dispositivo Removido");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida para 'Id'.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Lista de Dispositivos: ");
                        gateway.ListarDispositivos();
                        break;

                    case "4":
                        Console.WriteLine("Tchau... ");
                        return;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
