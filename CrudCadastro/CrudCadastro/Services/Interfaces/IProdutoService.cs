using CrudCadastro.Models;

namespace CrudCadastro.Services.Interfaces
{
    public interface IProdutoService
    {
        void ApagarProduto(Produto produto);
        void AtualizarProduto(Produto produto);
        void CadastroProduto(Produto produto);
        List<Produto> ListaProduto();
        Produto ProdutoId(int IdProduto);
    }
}