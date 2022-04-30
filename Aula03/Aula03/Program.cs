using System;
using System.Globalization;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int idade = 28;
                double saldo = 10.35784;
                string nome = "Maria";

                //Console.WriteLine(nome + " " + saldo + " " + idade);

                //placeholder - lugar para colocar a variavel.

                Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais",
                    nome, idade, saldo);

                //para colocar um maximo de casas decimais.
                Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais",
                   nome, idade, saldo);

                //para trocar para ponto.
                Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
         
        }
    }
}
