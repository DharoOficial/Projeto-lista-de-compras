using System;
using System.Collections.Generic;
namespace ListaCarrinho
{
    public class Carrinho
    {
        public float valorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();
        public void Adicionar(Produto Produto)
        {
            carrinho.Add(Produto);
        }

        public void Remover(Produto Produto)
        {
            carrinho.Remove(Produto);
        }

        public void AlterarItem(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.codigo == _codigo).nome = _novoProduto.nome;
            carrinho.Find(x => x.codigo == _codigo).preco = _novoProduto.preco;
        }

        public void MostrarItens()
        {
            foreach(Produto p in carrinho)
            {
                Console.WriteLine($"O preço do produto é deR$: {p.preco} nome do produto é: {p.nome}");
            }
        }
        public void MostrarTotal()
        {
            foreach(Produto p in carrinho)
            {
                valorTotal += p.preco;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"O valor total dos itens é: R$ {valorTotal}");
        }
    
    }
}   