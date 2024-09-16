using CreditEvaluationAPI.Models;
using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<Produto>? Produtos { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseOracle("User Id=rm551007;Password=030803;Data Source=oracle.fiap.com.br/orlc;");
        }
    }
}
