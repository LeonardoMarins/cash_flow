using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Domain.Repositories.Expenses;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Application
{
    public static class DependecyInjectionExtension
    {
        public static void AddAplication(this IServiceCollection services)
        {
            services.AddScoped<IRegisterExpenseUseCase, RegisterExpenseUseCase>(); // quando la no construtor onde eu utilizar a injeção de dependencia colocar IExpenseRepository vai me devolver uma instacia de ExpenseRepository
        }
    }
}
