using CreditEvaluationAPI.Models;
using CreditEvaluationAPI.Repositorie;
using Microsoft.AspNetCore.Mvc;

namespace CreditEvaluationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _repository;

        public ProdutosController(IProdutoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Produto>>> GetAll()
        {
            return await _repository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetById(int id)
        {
            var produto = await _repository.GetById(id);
            if (produto == null)
                return NotFound();
            return produto;
        }

        [HttpPost]
        public async Task<ActionResult> Add(Produto produto)
        {
            await _repository.Add(produto);
            return CreatedAtAction(nameof(GetById), new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Produto produto)
        {
            if (id != produto.Id)
                return BadRequest();
            await _repository.Update(produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _repository.Delete(id);
            return NoContent();
        }
    }

}
