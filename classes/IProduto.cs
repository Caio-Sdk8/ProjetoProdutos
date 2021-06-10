namespace ProjetoProdutos.classes
{
    public interface IProduto
    {
        void cadastrar(Produto produto);
        void listar();
        void deletar(Produto produto);
    }
}