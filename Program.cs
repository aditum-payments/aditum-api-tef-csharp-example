using System;
using example.servico;
using example_csharp_api_tef.entities;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n\n*---------------------------*");
                Console.WriteLine("| Bem-vindo ao TEF Aditum   |");
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("| 1 - Init                  |");
                Console.WriteLine("| 2 - Cobrança              |");
                Console.WriteLine("| 3 - Confirmar             |");
                Console.WriteLine("| 4 - Cancelar              |");
                Console.WriteLine("| 5 - Reverter              |");
                Console.WriteLine("| 6 - Transações Pendentes  |");
                Console.WriteLine("| 7 - Display               |");
                Console.WriteLine("|---------------------------|");
                Console.WriteLine("| 0 - Sair                  |");
                Console.WriteLine("*---------------------------*");
                int cursor = Int32.Parse(Console.ReadLine());
                if (cursor == 1)
                {
                    var initRequest = new InitRequest(true, "Exemplo", "1.0.0", "733461304", new PinpadMessages("Aprovado", "Negado", "Iniciando...", "Enviando..."));
                    ServicoTEF.Init(initRequest);
                }
                else if (cursor == 2)
                {
                    var charge = new Charge(100, "Credit", "None");
                    ServicoTEF.Payment(charge);
                }
                else if (cursor == 3)
                {
                    System.Threading.Tasks.Task task = ServicoTEF.ConfirmAsync("254");
                }
                else if (cursor == 0)
                {
                    break;
                }
            } while (true);
        }
    }
}

