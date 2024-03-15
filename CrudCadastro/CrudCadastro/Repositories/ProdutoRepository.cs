using CrudCadastro.Data;
using CrudCadastro.Models;
using CrudCadastro.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrudCadastro.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        => _context = context;

        public void CadastroProduto(Produto produto)
        {
            _context.Add(produto);

            _context.SaveChanges();
        }

        public void AtualizarProduto(Produto produto)
        {
            _context.Update(produto);

            _context.SaveChanges();
        }

        public List<Produto> ListaProduto()
        {
            var lista = _context.Produtos.AsNoTracking().ToList();

            return lista;
        }

        public Produto ProdutoId(int IdProduto)
        {
            var idProduto = _context.Produtos.Where(x => x.Id == IdProduto).FirstOrDefault();

            return idProduto;
        }

        public bool ProdutosNomesIguais(string nome)
        {
            var nomeProduto = _context.Produtos.AsNoTracking().Any(x => x.Nome == nome);

            return nomeProduto;
        }

        public void ApagarProduto(Produto produto)
        {
            _context.Update(produto);

            _context.SaveChanges();
        }

        public void AtualizarProdutoAtivo(Produto produto)
        {
            _context.Attach(produto);

            produto.Ativo = false;

            _context.Entry(produto).Property(p => p.Ativo).IsModified = true;

            _context.SaveChanges();
        }
    }
}
