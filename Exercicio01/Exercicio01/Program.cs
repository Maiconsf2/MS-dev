﻿using System;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            /*Usando os valores das variáveis, produza a seguinte saída na tela do console:
                Produtos:
                Computador, cujo preço é $ 2100,00
                Mesa de escritório, cujo preço é $ 650,20
                Registro: 30 anos de idade, código 5290 e gênero M
                Medida com oito casas decimais: 53,23456700
                Arredondado (três casas decimais): 53,235
            */

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é {1}", produto1, preco1);
        }
    }
}
