using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using BrokerApiConsoleTest.Trading212.Models;

namespace BrokerApiConsoleTest.Trading212
{
    /// <summary>
    /// Handles communication with the Trading 212 API and deserializes results.
    /// </summary>
    public class Trading212Service
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Handles communication with the Trading 212 API and deserializes results.
        /// </summary>
        /// <param name="httpClient">HTTP client.</param>
        /// <param name="configuration">Trading212 configuration (For simplicity of a project, not an interface).</param>
        public Trading212Service(HttpClient httpClient, Trading212Configuration configuration)
        {
            _httpClient = httpClient;

            var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{configuration.ApiKey}:{configuration.ApiSecret}"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

            if (_httpClient.BaseAddress == null && !string.IsNullOrEmpty(configuration.BaseUrl))
                _httpClient.BaseAddress = new Uri(configuration.BaseUrl);
        }

        /// <summary>
        /// Gets account summary information.
        /// </summary>
        /// <returns>Account summary response model (Deserialized JSON to models).</returns>
        public async Task<AccountSummaryResponse?> GetAccountSummary()
        {
            try
            {
                using var response = await _httpClient.GetAsync("/api/v0/equity/account/summary");

                response.EnsureSuccessStatusCode();

                var summary = await response.Content.ReadFromJsonAsync<AccountSummaryResponse>();
                return summary;
            }
            catch (HttpRequestException ex)
            {
                System.Console.WriteLine($"API error: {ex.Message}");
                return null;
            }
        }
    }
}