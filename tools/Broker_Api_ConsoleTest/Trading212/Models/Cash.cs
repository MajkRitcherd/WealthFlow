using System.Text.Json.Serialization;

namespace BrokerApiConsoleTest.Trading212.Models
{
    /// <summary>
    ///  Represents the breakdown of available and reserved cash on the Trading 212 account.
    /// </summary>
    /// <param name="AvailableToTrade">Cash available for trading/investing.</param>
    /// <param name="ReservedForOrders">Cash reserved for orders.</param>
    /// <param name="InPies">Cash invested in Pies.</param>
    public record Cash(
        [property: JsonPropertyName("availableToTrade")] double AvailableToTrade,
        [property: JsonPropertyName("reservedForOrders")]double ReservedForOrders,
        [property: JsonPropertyName("inPies")] double InPies
    );
}