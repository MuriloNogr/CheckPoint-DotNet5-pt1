using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Produtos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoApplicationService _produtoApplicationService;

        public ProdutoController(IProdutoApplicationService produtoApplicationService)
        {
            _produtoApplicationService = produtoApplicationService; 
        }

        /// <summary>
        /// Metodo para obter todos os dados do protudo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces<IEnumerable<ProdutoEntity>>]
        public IActionResult Get()
        {
            var categorias = _produtoApplicationService.ObterTodosProdutos();

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel obter os dados");
        }

        /// <summary>
        ///  Metodo para obter todos os dados do produto por Id
        /// </summary>
        /// <param name="id"> Parametro que identifica o produto</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces<ProdutoEntity>]
        public IActionResult GetPorId(int id)
        {
            var categorias = _produtoApplicationService.ObterProdutoPorId(id);

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel obter os dados");
        }

        /// <summary>
        /// Metodo para salvar os dados do produto
        /// </summary>
        /// <param name="entity"> Modelo de dados para salvar produto</param>
        /// <returns></returns>
        [HttpPost]
        [Produces<ProdutoEntity>]
        public IActionResult Post([FromBody] ProdutoEntity entity)
        {
            var categorias = _produtoApplicationService.SalvarDadosProduto(entity);

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel salvar os dados");
        }

        /// <summary>
        /// Metodo para atualizar os dados do produto 
        /// </summary>
        /// <param name="entity"> Modelo de dados para atualizar produto</param>
        /// <returns></returns>
        [HttpPut]
        [Produces<ProdutoEntity>]
        public IActionResult Put([FromBody] ProdutoEntity entity)
        {
            var categorias = _produtoApplicationService.EditarDadosProduto(entity);

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel salvar os dados");
        }

        /// <summary>
        ///  Metodo para deletar os dados do produto
        /// </summary>
        /// <param name="id"> Identificador do produto</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces<ProdutoEntity>]
        public IActionResult Delete(int id)
        {
            var categorias = _produtoApplicationService.DeletarDadosProduto(id);

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel deletar os dados");
        }
    }
}
