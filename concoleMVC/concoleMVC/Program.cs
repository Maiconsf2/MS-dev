using concoleMVC.Controllers;
using concoleMVC.Models;
using System;

namespace consoleMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.ListarProdutos();

        }
    }
}