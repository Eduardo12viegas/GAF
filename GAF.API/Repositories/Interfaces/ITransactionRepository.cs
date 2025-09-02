using GAF.API.Models;

namespace GAF.API.Repositories.Interfaces;

    public class ITransactionRepository
    {
        Task<IEnumerable<Transaction>> GetByDateRangeAsync(
            string userId);
        Task<Transaction> GetByIdAsync(int id, string userId);
        Task<IEnumerable<Transaction>> GetByDateRangeAsync(
            string userId, DateTime starDate, DateTime endDate);
            Task<Transaction> CreateAsync(Transaction transaction);
            Task<Transaction> UpdateAsync(Transaction transaction);
            Task<bool> DeleteAsync(int id, string userId);
            Task<decimal> GetTotalIncomeByMonthAsync(
                string userId, int month, int year);
            Task<IEnumerable<Transaction>> GetRecentTransactionAsync(
                string userId, int count = 10);
            )
            )
        )
    }

