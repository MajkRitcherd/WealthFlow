using System.Text.Json.Serialization;

namespace BrokerApiConsoleTest.Trading212.Models
{
    /// <summary>
    /// Represents the comprehensive summary of the Trading 212 account.
    /// </summary>
    /// <param name="Id">Account ID.</param>
    /// <param name="Currency">Account's currency.</param>
    /// <param name="TotalValue">Account's total value.</param>
    /// <param name="Cash">Cash on account.</param>
    /// <param name="Investments">Acount's investments.</param>
    public record AccountSummaryResponse(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("currency")] string Currency,
        [property: JsonPropertyName("totalValue")] double TotalValue,
        [property: JsonPropertyName("cash")] Cash Cash,
        [property: JsonPropertyName("investments")] Investments Investments
        );
}