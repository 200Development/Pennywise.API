namespace Pennywise.API.Interfaces.ViewModels
{
    public interface IAvgMonthlySpendingViewModel
    {
        string Category { get; }
        decimal Avg3MonthSpending { get; }
        decimal Avg6MonthSpending { get; }
        decimal Avg12MonthSpending { get; }
    }
}
