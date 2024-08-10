using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Infrastructure.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Infrastructure
{
    public static class DependecyInjectionExtension
    {
        public static void AddInfraStructure(this IServiceCollection services)
        {
            services.AddScoped<IExpensesRepository, ExpensesRepository>(); // quando la no construtor onde eu utilizar a injeção de dependencia colocar IExpenseRepository vai me devolver uma instacia de ExpenseRepository
        }
    }
}
