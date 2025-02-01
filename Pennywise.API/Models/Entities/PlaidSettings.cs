namespace Pennywise.API.Models.Entities
{
    public class PlaidSettings
    {
        public required string BaseAddress { get; set; }
        public required string ClientId { get; set; }
        public required string PlaidSandboxSecret { get; set; }
        public required string PlaidProductionSecret { get; set; }
    }
}
