using Microsoft.Extensions.Configuration;

namespace BrokerApiConsoleTest.Trading212
{
    /// <summary>
    /// Holds configuration to Trading 212 API, such as BaseUrl, ApiKey and ApiSecret.
    /// </summary>
    /// <param name="pathToJsonFile">Path to AppSettings.json file.</param>
    public class Trading212Configuration(string pathToJsonFile)
    {
        private const string configurationKey = "Trading212";

        private readonly IConfigurationRoot configurationBuilder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile(pathToJsonFile, optional: true, reloadOnChange: true)
            .Build();

        /// <summary>
        /// Gets Trading 212 API key ('username').
        /// </summary>
        public string? ApiKey => configurationBuilder[$"{configurationKey}:ApiKey"];

        /// <summary>
        /// Gets Trading 212 API Secret ('password').
        /// </summary>
        public string? ApiSecret => configurationBuilder[$"{configurationKey}:ApiSecret"];

        /// <summary>
        /// Gets base URL to Trading 212 API.
        /// </summary>
        public string? BaseUrl => configurationBuilder[$"{configurationKey}:BaseUrl"];

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{configurationKey} configuration\nBaseUrl: {BaseUrl}\nApiKey: {ApiKey}\nApiSecret: {ApiSecret}";
        }
    }
}