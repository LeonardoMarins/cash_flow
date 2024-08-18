using CashFlow.Application.AutoMapper;
using CashFlow.Application.UseCases.Expenses.Delete;
using CashFlow.Application.UseCases.Expenses.GetAll;
using CashFlow.Application.UseCases.Expenses.GetById;
using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Application.UseCases.Expenses.Update;
using CashFlow.Domain.Repositories.Expenses;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Application
{
    public static class DependecyInjectionExtension
    {
        public static void AddAplication(this IServiceCollection services)
        {
            AddAutoMapper(services);
            AddUseCases(services);
        }

        public static void AddAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));
        }

        public static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<IGetAllExpenseUseCase, GetAllExpenseUseCase>();
            services.AddScoped<IDeleteExpenseUseCase, DeleteExpenseUseCase>();
            services.AddScoped<IUpdateExpenseUseCase, UpdateExpenseUseCase>();
            services.AddScoped<IGetByIdExpenseUseCase, GetByIdExpenseUseCase>();
            services.AddScoped<IRegisterExpenseUseCase, RegisterExpenseUseCase>(); // quando la no construtor onde eu utilizar a injeção de dependencia colocar IExpenseRepository vai me devolver uma instacia de ExpenseRepository
        }
    }
}
