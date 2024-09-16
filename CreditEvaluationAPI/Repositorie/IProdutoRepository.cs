using CreditEvaluationAPI.Models;

namespace CreditEvaluationAPI.Repositorie
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> GetAll();
        Task<Produto> GetById(int id);
        Task Add(Produto produto);
        Task Update(Produto produto);
        Task Delete(int id);
    }
}
