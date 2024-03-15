using CrudCadastro.Models;

namespace CrudCadastro.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        void ApagarProduto(Produto produto);
        void AtualizarProduto(Produto produto);
        void AtualizarProdutoAtivo(Produto produto);
        void CadastroProduto(Produto produto);
        List<Produto> ListaProduto();
        Produto ProdutoId(int IdProduto);
        bool ProdutosNomesIguais(string nome);
    }
}