using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAda1.Exercicios
{
    public class Exercicio3
    {
        public static void Resolucao()
        {
            Console.WriteLine("Digite seu primeiro nome: ");
            string nome = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine().ToUpper();

            Console.WriteLine($"Suas iniciais são {nome[0]}{sobrenome[0]}");
        }
    }
}
