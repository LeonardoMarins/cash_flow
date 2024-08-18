using CashFlow.Domain.Entities;

namespace CashFlow.Application.UseCases.Expenses.GetById
{
    public interface IGetByIdExpenseUseCase
    {
        Task<Expense> Execute(int id);
    }
}
