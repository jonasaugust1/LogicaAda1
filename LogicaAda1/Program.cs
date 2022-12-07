using LogicaAda1.Exercicios;

namespace LogicaAda1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.WriteLine("\nDigite o numero do exercicio que você quer ver: (1-6)");
                bool ehNumero = int.TryParse(Console.ReadLine(), out int exercicio);

                switch (exercicio)
                {
                    case 1:
                        Exercicio1.Resolucao();
                        break;
                    case 2:
                        Exercicio2.Resolucao();
                        break;
                    case 3:
                        Exercicio3.Resolucao();
                        break;
                    case 4:
                        Exercicio4.Resolucao();
                        break;
                    case 5:
                        Exercicio5.Resolucao();
                        break;
                    case 6:
                        Exercicio6.Resolucao();
                        break;
                    default:
                        Console.WriteLine("Digite um número válido");
                        break;
                }

                Console.WriteLine("\nPressione a tecla espaço 2 vezes para continuar");
                Console.WriteLine("OU");
                Console.WriteLine("Pressione Enter 2 vezes para sair");

                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                }

            } while (Console.ReadKey().Key != ConsoleKey.Enter);
            
        }
    }
}