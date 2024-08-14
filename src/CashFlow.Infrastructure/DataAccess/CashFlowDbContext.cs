using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess
{
    internal class CashFlowDbContext : DbContext
    {
        public CashFlowDbContext(DbContextOptions options) : base(options)  // vai repasar para a classe base as options que foram passadas
        {  
        }
        public DbSet<Expense> Expenses { get; set; }

    }
}
