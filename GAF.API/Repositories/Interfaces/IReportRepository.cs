using GAF.API.Models;

namespace GAF.API.Repositories.Interfaces;

    public interface IReportRepository
    {
        Task<Report> GetMonthlyReportAsync(string userId, int month, int year);
        Task<IEnumerable<Report>> GetYearlyReportAsync(string user, int year);
        Task<Report> CreateOrUpdateMonthlyreportAsync (Report report);
    }
