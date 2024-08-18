using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Application.UseCases.Expenses.GetById
{
    public class GetByIdExpenseUseCase : IGetByIdExpenseUseCase
    {
        private readonly IExpensesRepository _expensesRepository;
        public GetByIdExpenseUseCase(
            IExpensesRepository expensesRepository)
        {
            _expensesRepository = expensesRepository;
        }
        public async Task<Expense> Execute(int id)
        {
            return await _expensesRepository.GetById(id);
        }
    }
}
