using AutoMapper;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Domain.Repositories;
using CashFlow.Domain.Entities;
using CashFlow.Communication.Responses;
using CashFlow.Communication.Requests;

namespace CashFlow.Application.UseCases.Expenses.Update
{
    public class UpdateExpenseUseCase : IUpdateExpenseUseCase
    {
        private readonly IExpensesRepository _expensesRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateExpenseUseCase(
            IExpensesRepository expensesRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _expensesRepository = expensesRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ResponseUpdateExpenseJson> Execute(int id, RequestUpdateExpenseJson request)
        {
           var entityToUpdate = _expensesRepository.Get(id); // recupero a entidade pelo id

            _mapper.Map(request, entityToUpdate); //mapeamento do que veio no request para a entidade

            await _unitOfWork.Commit(); // faço o savechanges

            return _mapper.Map<ResponseUpdateExpenseJson>(entityToUpdate); // retorno a entidade atualizada


        }
    }
}
