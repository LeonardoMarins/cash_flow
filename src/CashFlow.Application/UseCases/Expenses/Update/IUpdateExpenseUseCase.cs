using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;

namespace CashFlow.Application.UseCases.Expenses.Update
{
    public interface IUpdateExpenseUseCase
    {
        Task<ResponseUpdateExpenseJson> Execute(int id, RequestUpdateExpenseJson request);
    }
}
