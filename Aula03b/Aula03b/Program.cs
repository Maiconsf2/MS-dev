﻿using System;

namespace Aula03b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double media = 0;
            Double idade1 = 0;
            Double idade2 = 0;
            Double idade3 = 0;
            Double idade4 = 0;
            Double idade5 = 0;
            Console.WriteLine("Programa que calcula a idade media de cinco alunos");
            Console.Write("Informe a idade do 1° alunos : ");
            idade1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a idade do 2° alunos : ");
            idade2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a idade do 3° alunos : ");
            idade3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a idade do 4° alunos : ");
            idade4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a idade do 5° alunos : ");
            idade5 = Convert.ToDouble(Console.ReadLine());
            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
            Console.WriteLine("A ídade média dos alunos é " + media);
        }
    }
}
