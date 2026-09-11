using System.Text.Json.Serialization;

namespace BrokerApiConsoleTest.Trading212.Models
{
    /// <summary>
    /// Contains information about the current state, costs, and profit/loss of investments.
    /// </summary>
    /// <param name="CurrentValue">Portfolio's current value.</param>
    /// <param name="TotalCost">Total amount of invested money.</param>
    /// <param name="RealizedProfitLoss">Realized Profit/Loss.</param>
    /// <param name="UnrealizedProfitLoss">Unrealized Profit/Loss.</param>
    public record Investments(
        [property: JsonPropertyName("currentValue")] double CurrentValue,
        [property: JsonPropertyName("totalCost")] double TotalCost,
        [property: JsonPropertyName("realizedProfitLoss")] double RealizedProfitLoss,
        [property: JsonPropertyName("unrealizedProfitLoss")] double UnrealizedProfitLoss
    );
}