using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAda1.Exercicios
{
    public class Exercicio1
    {
        public static void Resolucao()
        {
            string titulo = "FOTOSSÍNTESE";

            string primeiraParte = "A água e os sais minerais absorvidos pelas raízes sobem " +
                "através dos vasos lenhosos do caule e chegam às folhas.";

            string segundaParte = "Nas folhas, existe uma substância verde, a clorofila, " +
                "que absone a energia luminosa do sol.\r\nAo mesmo tempo, por meio dos estômatos presentes " +
                "nas folhas, a planta absorve gás carbônico do ar.";

            string terceiraParte = "Usando a energia solar, o gás carbônico e o hidrogênio contido na água " +
                "retirada do solo,\r\napós complicadas reações químicas, " +
                "a planta produz açúcares (glicose).";

            Console.WriteLine("Trabalho de Ciências");
            Console.WriteLine("pressione a seta da esquerda para passar as páginas");

            if (Console.ReadKey().Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                Console.WriteLine(titulo);

                if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    Console.WriteLine(primeiraParte);

                    if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                    {
                        Console.Clear();
                        Console.WriteLine(segundaParte);

                        if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                        {
                            Console.Clear();
                            Console.WriteLine(terceiraParte);
                        }
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("FIM!");
        }
    }
}
