using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAda1.Exercicios
{
    public class Exercicio4
    {
        public static void Resolucao()
        {
            Console.WriteLine("Digite seu primeiro nome: ");
            string nome = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine().ToUpper();

            Console.WriteLine($"As ultimas letras do seu nome e sobrenome são " +
                $"{nome[nome.Length -1 ]}{sobrenome[sobrenome.Length - 1]}");
        }
    }
}
