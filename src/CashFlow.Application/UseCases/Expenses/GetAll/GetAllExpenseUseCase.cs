using AutoMapper;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Domain.Repositories;
using CashFlow.Domain.Entities;

namespace CashFlow.Application.UseCases.Expenses.GetAll
{
    public class GetAllExpenseUseCase : IGetAllExpenseUseCase
    {
        private readonly IExpensesRepository _expensesRepository;

        public GetAllExpenseUseCase(
            IExpensesRepository expensesRepository)
        {
            _expensesRepository = expensesRepository;
        }
        public async Task<List<Expense>> Execute()
        {
            var entities = await _expensesRepository.GetAll(); // retornar uma lista de entidades

            return entities;
        }
    }
}
