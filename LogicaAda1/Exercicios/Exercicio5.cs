using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAda1.Exercicios
{
    public class Exercicio5
    {
        public static void Resolucao()
        {
            Random random = new Random();
            string numero1 = random.Next(10000, 99999).ToString();
            string numero2 = random.Next(10000, 99999).ToString();

            int numeroSorteado = int.Parse(numero1.Substring(2) + numero2.Substring(2));

            Console.WriteLine($"numero 1: {numero1}");
            Console.WriteLine($"numero 2: {numero2}");
            Console.WriteLine($"O numero sortedo foi: {numeroSorteado}");
        }
    }
}
