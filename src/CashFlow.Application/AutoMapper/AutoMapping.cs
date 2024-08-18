using AutoMapper;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;

namespace CashFlow.Application.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            RequestToEntity();
            EntityToResponse();
        }

        private void RequestToEntity()
        {
            CreateMap<RequestRegisterExpenseJson, Expense>(); //RequestRegisterExpenseJson - origem / Expense - destino
        }

        private void EntityToResponse()
        {
            CreateMap<Expense, ResponseRegisterExpenseJson>(); //Expense - origem / ResponseRegisterExpenseJson - destino
        }
    }
}
