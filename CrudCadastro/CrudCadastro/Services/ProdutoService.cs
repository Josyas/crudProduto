using CrudCadastro.Models;
using CrudCadastro.Repositories.Interfaces;
using CrudCadastro.Services.Interfaces;

namespace CrudCadastro.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        => _produtoRepository = produtoRepository;

        public void CadastroProduto(Produto produto)
        {
            var produtoExiste = NomeProdutoIguais(produto.Nome);

            if (!produtoExiste)
            {
                var produtoCriado = ProdutoCriado(produto);

                _produtoRepository.CadastroProduto(produtoCriado);
            }
            else
            {
                throw new Exception("Nome do produto existente.");
            }
        }

        public void AtualizarProduto(Produto produto)
        {
            _produtoRepository.AtualizarProduto(produto);
        }

        public List<Produto> ListaProduto()
        {
            var lista = _produtoRepository.ListaProduto();

            return lista;
        }

        public Produto ProdutoId(int IdProduto)
        {
            var produtoId = _produtoRepository.ProdutoId(IdProduto);

            return produtoId;
        }

        public void ApagarProduto(Produto produto)
        {
            _produtoRepository.ApagarProduto(produto);
        }

        private Produto ProdutoCriado(Produto produto)
        {
            Produto cadastroProduto = new()
            {
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                DataValidade = produto.DataValidade,
                Idcategoria = produto.Idcategoria,
                Valor = produto.Valor,
                Ativo = true
            };

            return produto;
        }

        private bool NomeProdutoIguais(string nome)
        {
            var produtoExiste = _produtoRepository.ProdutosNomesIguais(nome);

            return produtoExiste;
        }
    }
}
