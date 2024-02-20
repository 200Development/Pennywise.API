using System.ComponentModel.DataAnnotations;
// ReSharper disable InconsistentNaming

namespace Pennywise.API.Models.Enums
{

    /// <summary>
    /// Account Subtypes
    /// </summary>
    /// <remarks>
    /// See <see href="https://plaid.com/docs/api/accounts/#account-type-schema">for more information</see>
    /// </remarks>
    public enum AccountSubtype
    {
        Checking,
        Savings,
        HSA,
        CD,
        [Display(Name = "Money Market")] MoneyMarket,
        PayPal,
        [Display(Name = "Pre-Paid")] Prepaid,
        [Display(Name = "Cash Management")] CashManagement,
        EBT,
        [Display(Name = "Credit Card")] CreditCard,
        Auto,
        Business,
        Commercial,
        Construction,
        Consumer,
        [Display(Name = "Home Equity")] HomeEquity,
        Loan,
        Mortgage,
        Overdraft,
        [Display(Name = "Line of Credit")] LineOfCredit,
        Student,
        Other,
        [Display(Name = "529")] Education529,
        [Display(Name = "401a")] Investment401a,
        [Display(Name = "401k")] Investment401k,
        [Display(Name = "403B")] Investment403B,
        [Display(Name = "457b")] Investment457b,
        Brokerage,
        [Display(Name = "Cash ISA")] CashISA,
        [Display(Name = "Crypto Exchange")] CryptoExchange,
        [Display(Name = "Education Savings Account")]
        EducationSavingsAccount,
        [Display(Name = "Fixed Annuity")] FixedAnnuity,
        GIC,
        [Display(Name = "Health Reimbursement Arrangement")]
        HealthReimbursementArrangement,
        IRA,
        ISA,
        Keogh,
        LIF,
        [Display(Name = "Life Insurance")] LifeInsurance,
        LIRA,
        LRIF,
        LRSP,
        [Display(Name = "Mutual Fund")] MutualFund,
        [Display(Name = "Non-Custodial Wallet")]
        NonCustodialWallet,
        [Display(Name = "Non-Taxable Brokerage Account")]
        NonTaxableBrokerageAccount,
        [Display(Name = "Other Annuity")] OtherAnnuity,
        [Display(Name = "Other Insurance")] OtherInsurance,
        Pension,
        PRIF,
        [Display(Name = "Profit Sharing Plan")]
        ProfitSharingPlan,
        QSHR,
        RDSP,
        RESP,
        Retirement,
        RLIF,
        Roth,
        [Display(Name = "Roth 401k")] Roth401k,
        RRIF,
        RRSP,
        SARSEP,
        [Display(Name = "SEP IRA")] SEPIRA,
        [Display(Name = "Simple IRA")] SimpleIRA,
        SIPP,
        [Display(Name = "Stock Plan")] StockPlan,
        TSFA,
        Trust,
        UGMA,
        UTMA,
        [Display(Name = "Variable Annuity")] VariableAnnuity
    }
}