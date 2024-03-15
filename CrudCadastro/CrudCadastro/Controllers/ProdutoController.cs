using CrudCadastro.Models;
using CrudCadastro.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CrudCadastro.Controllers
{
    [Route("api/produto")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        => _produtoService = produtoService;

        [HttpPost]
        public ActionResult CadastroProduto(Produto produto)
        {
            try
            {
                _produtoService.CadastroProduto(produto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public ActionResult AtualizarProduto(Produto produto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            
            _produtoService.AtualizarProduto(produto);

            return Ok();
        }

        [HttpGet]
        public ActionResult<List<Produto>> ListaProduto()
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var listaProduto = _produtoService.ListaProduto();

            return Ok(listaProduto);
        }
    }
}
