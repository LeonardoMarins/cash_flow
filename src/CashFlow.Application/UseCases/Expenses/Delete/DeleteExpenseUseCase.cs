using AutoMapper;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Application.UseCases.Expenses.Delete
{
    public class DeleteExpenseUseCase : IDeleteExpenseUseCase
    {
        private readonly IExpensesRepository _expensesRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DeleteExpenseUseCase(
            IExpensesRepository expensesRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _expensesRepository = expensesRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Execute(int id)
        {
           await _expensesRepository.Delete(id);

            await _unitOfWork.Commit();
        }
    }
}
