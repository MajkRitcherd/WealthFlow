using BrokerApiConsoleTest.Trading212;

var client = new HttpClient();
var configuration = new Trading212Configuration("appsettings.json");
var service = new Trading212Service(client, configuration);

var accountSummary = await service.GetAccountSummary();

if (accountSummary == null)
{
    return;
}

System.Console.WriteLine($"ID: {accountSummary.Id}");
System.Console.WriteLine($"TotalValue: {accountSummary.TotalValue}");