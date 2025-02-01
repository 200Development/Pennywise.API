using Pennywise.API.Interfaces.Clients;
using Pennywise.API.Interfaces.Responses;
using Pennywise.API.Models.Requests;
using Pennywise.API.Models.Responses;

namespace Pennywise.API.Clients
{
    public class PlaidClient : IPlaidClient
    {
        private readonly HttpClient _client;

        public PlaidClient(HttpClient client)
        {
            _client = client;
        }


        public async Task<ILinkTokenCreateResponse?> LinkTokenCreateAsync(LinkTokenCreateRequest request)
        {
            var uri = _client.BaseAddress + "link/token/create";
            var response = await _client.PostAsJsonAsync(uri, request);

            response.EnsureSuccessStatusCode();

            try
            {
                return await response.Content.ReadFromJsonAsync<LinkTokenCreateResponse>();
            }
            catch (HttpRequestException ex)
            {
                //todo: log HttpRequestException
                return null;
            }
            catch (Exception ex)
            {
                //todo: log Exception
                return null;
            }
        }

        public async Task<IPublicTokenExchangeResponse?> ExchangePublicTokenAsync(PublicTokenExchangeRequest request)
        {
            var uri = _client.BaseAddress + "item/public_token/exchange";
            var response = await _client.PostAsJsonAsync(uri, request);

            response.EnsureSuccessStatusCode();

            try
            {
                return await response.Content.ReadFromJsonAsync<PublicTokenExchangeResponse>();
            }
            catch (HttpRequestException ex)
            {
                //todo: log HttpRequestException
                return null;
            }
            catch (Exception ex)
            {
                //todo: log Exception
                return null;
            }
        }

        public async Task<IGetAccountsResponse?> GetAccountsAsync(GetAccountsRequest request)
        {
            var uri = _client.BaseAddress + "accounts/balance/get";
            var responseJson = await _client.PostAsJsonAsync(uri, request);

            responseJson.EnsureSuccessStatusCode();

            try
            {
                return await responseJson.Content.ReadFromJsonAsync<GetAccountsResponse>();
            }
            catch (HttpRequestException ex)
            {
                //todo: log HttpRequestException
                return null;
            }
            catch (Exception ex)
            {
                //todo: log Exception
                return null;
            }
        }

        public async Task<ITransactionsSyncResponse?> GetTransactionsAsync(TransactionsSyncRequest request)
        {
            var uri = _client.BaseAddress + "transactions/sync";
            Console.WriteLine($"uri: {uri}");
            Console.WriteLine($"request: {request}");
            var responseJson = await _client.PostAsJsonAsync(uri, request);

            responseJson.EnsureSuccessStatusCode();

            try
            {
                var json = await responseJson.Content.ReadAsStringAsync();
                return await responseJson.Content.ReadFromJsonAsync<TransactionsSyncResponse>();
            }
            catch (HttpRequestException ex)
            {
                //todo: log HttpRequestException
                return null;
            }
            catch (Exception ex)
            {
                //todo: log Exception
                return null;
            }
        }
    }
}