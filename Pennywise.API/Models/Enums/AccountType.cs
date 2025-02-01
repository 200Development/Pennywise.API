/*******************************************************************
// 
// Link to Plaid documentation explaining the structure of this model:
// https://plaid.com/docs/api/accounts/#account-type-schema
// 
// *******************************************************************/

namespace Pennywise.API.Models.Enums
{

    public enum AccountType
    {
        Depository,
        Credit,
        Loan,
        Investment
    }
}