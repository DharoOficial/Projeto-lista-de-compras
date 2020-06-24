using System;

namespace ListaCarrinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Rainbow six", 59.90f);
            Produto p2 = new Produto(2, "The Last of us II", 300f);
            Produto p3 = new Produto(3, "Counter strike: GO", 14.90f);
            Produto p4 = new Produto(4, "Halo", 99.90f);
            Produto p5 = new Produto(5, "FIFA 21", 349.90f);
            Produto p6 = new Produto(6, "Fortnite", 60f);

            Carrinho carrinho = new Carrinho();
            carrinho.Adicionar(p1);
            carrinho.Adicionar(p2);
            carrinho.Adicionar(p3);
            carrinho.Adicionar(p4);
            carrinho.Adicionar(p5);
            carrinho.Remover(p5);
            carrinho.AlterarItem(2 , p6);
            carrinho.MostrarItens();
            System.Console.WriteLine();
            carrinho.MostrarTotal();
            
        }
    }
}
