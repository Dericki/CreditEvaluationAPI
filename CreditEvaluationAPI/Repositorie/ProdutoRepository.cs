using CreditEvaluationAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CreditEvaluationAPI.Repositorie
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyDbContext _context;

        public ProdutoRepository(MyDbContext context)
        {
            _context = context;
        }

        // Implementa o método para obter todos os produtos
        public async Task<List<Produto>> GetAll()
        {
            return await _context.Produtos.ToListAsync();
        }

        // Implementa o método para obter um produto pelo ID
        public async Task<Produto> GetById(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        // Implementa o método para adicionar um novo produto
        public async Task Add(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        // Implementa o método para atualizar um produto
        public async Task Update(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
        }

        // Implementa o método para deletar um produto
        public async Task Delete(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }
    }
    }
