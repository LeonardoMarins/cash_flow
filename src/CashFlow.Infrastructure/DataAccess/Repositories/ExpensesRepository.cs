using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess.Repositories
{
    internal class ExpensesRepository : IExpensesRepository
    {
        private readonly CashFlowDbContext _dbContext;

        public ExpensesRepository(CashFlowDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task Add(Expense expense)
        {
           await _dbContext.Expenses.AddAsync(expense);

        }
        public async Task<List<Expense>> GetAll()
        {
            return await _dbContext.Expenses.ToListAsync();

        }
        public async Task<Expense> GetById(int id)
        {
            return await _dbContext.Expenses.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Expense Get(int id)
        {
            return _dbContext.Expenses.FirstOrDefault(x => x.Id == id);
        }

        public async Task Delete(int id)
        {
            var entityToDelete = await _dbContext.Expenses.FirstOrDefaultAsync(x => x.Id == id);

            if (entityToDelete != null)
            {
                _dbContext.Expenses.Remove(entityToDelete);
            }
        }


    }
}
