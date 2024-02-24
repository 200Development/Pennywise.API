using Pennywise.API.Interfaces.ViewModels;

namespace Pennywise.API.Models.ViewModels
{
    public class AvgMonthlySpendingViewModel : IAvgMonthlySpendingViewModel
    {
        public string Category { get; set; }
        public decimal Avg3MonthSpending { get; set; }
        public decimal Avg6MonthSpending { get; set; }
        public decimal Avg12MonthSpending { get; set; }
    }
}
