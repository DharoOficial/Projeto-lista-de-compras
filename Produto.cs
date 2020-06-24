namespace ListaCarrinho
{
    public class Produto
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public float preco { get; set; }

        public Produto (){

        }
        public Produto(int _codigo, string _nome, float _preco)
        {
            this.codigo = _codigo;
            this.nome = _nome;
            this.preco = _preco;
        }
    }
}