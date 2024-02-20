namespace Pennywise.API.Interfaces.Entities
{

    public interface IPersonalFinanceCategory
    {
        string Primary { get; set; }
        string Detailed { get; set; }
        string ConfidenceLevel { get; set; }
    }
}