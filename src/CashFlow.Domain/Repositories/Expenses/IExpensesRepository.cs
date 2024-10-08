﻿using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses
{
    public interface IExpensesRepository
    {
        Task Add(Expense expense);

        Task<List<Expense>?> GetAll();

        Task<Expense> GetById(int id);
        Expense Get(int id);
        Task Delete(int id);
    }
}
