using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAda1.Exercicios
{
    public class Exercicio6
    {
        public static void Resolucao()
        {
            Console.WriteLine("Digite um numero: ");
            bool ehNumero = int.TryParse(Console.ReadLine(), out int numero);

            while (!ehNumero)
            {
                Console.WriteLine("Digite um numero válido: ");
                ehNumero = int.TryParse(Console.ReadLine(), out numero);
            }

            int unidade = numero % 10;
            int dezena = (numero - unidade) / 10;

            int soma = unidade + dezena;

            string numString = numero.ToString();
            

            if (soma > 9)
            {
                soma = (soma - (soma % 10)) / 10;
                dezena = numString[0] - '0';
                dezena++;
                char dezenaMaisUm = numString[0];
                numString = numString.Replace(dezenaMaisUm.ToString(), dezena.ToString());
            }

            numString = numString.Insert(1, soma.ToString());

            int resultado = int.Parse(numString);

            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}
