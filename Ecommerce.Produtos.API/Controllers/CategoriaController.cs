using Ecommerce.Produtos.Application.Dtos;
using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Ecommerce.Produtos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaApplicationService _categoriaApplicationService;

        public CategoriaController(ICategoriaApplicationService categoriaApplicationService)
        {
            _categoriaApplicationService = categoriaApplicationService;
        }


        /// <summary>
        /// Metodo para obter todos os dados da categoria
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces<IEnumerable<CategoriaEntity>>]
        public IActionResult Get()
        {
            var categorias = _categoriaApplicationService.ObterTodasCategorias();

            if(categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel obter os dados");
        }

        /// <summary>
        ///  Metodo para obter todos os dados da categoria por Id
        /// </summary>
        /// <param name="id"> Parametro que identifica a categoria</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces<CategoriaEntity>]
        public IActionResult GetPorId(int id)
        {
            var categorias = _categoriaApplicationService.ObterCategoriaPorId(id);

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel obter os dados");
        }

        /// <summary>
        /// Metodo para salvar os dados da categoria
        /// </summary>
        /// <param name="entity"> Modelo de dados para salvar categoria</param>
        /// <returns></returns>
        [HttpPost]
        [Produces<CategoriaEntity>]
        public IActionResult Post([FromBody] CategoriaDto entity)
        {
            try
            {
                var categorias = _categoriaApplicationService.SalvarDadosCategoria(entity);

                if (categorias is not null)
                    return Ok(categorias);

                return BadRequest("Não foi possivel salvar os dados");
            }
            catch (Exception ex)
            {
                return BadRequest(new { 
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }

        /// <summary>
        /// Metodo para atualizar os dados da categoria 
        /// </summary>
        /// <param name="entity"> Modelo de dados para atualizar categoria</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Produces<CategoriaEntity>]
        public IActionResult Put(int id, [FromBody] CategoriaDto entity)
        {
            var categorias = _categoriaApplicationService.EditarDadosCategoria(id, entity);

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel salvar os dados");
        }

        /// <summary>
        ///  Metodo para deletar os dados da categoria
        /// </summary>
        /// <param name="id"> Identificador do categoria</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces<CategoriaEntity>]
        public IActionResult Delete(int id)
        {
            var categorias = _categoriaApplicationService.DeletarDadosCategoria(id);

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel deletar os dados");
        }
    }
}
