using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;

namespace CashFlow.Application.UseCases.Expenses.GetAll
{
    public interface IGetAllExpenseUseCase
    {
        Task<List<Expense>> Execute();
    }
}
