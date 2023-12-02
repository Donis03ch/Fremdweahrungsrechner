using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

class CurrencyConverter
{
    private const string ApiUrl = "https://www.backend-rates.bazg.admin.ch/api/xmldaily";

    static async Task Main()
    {
        Console.WriteLine("Währungsumrechner");
        Console.WriteLine("-----------------");

        try
        {
            var converter = new CurrencyConverter();
            await converter.Run();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
        }
    }

    public async Task Run()
    {
        // Währungscodes für Umrechnung
        List<string> currencies = GetAvailableCurrencies();

        // Benutzer wählt Ausgangs- und Zielwährung aus
        Console.WriteLine("Verfügbare Währungen:");
        DisplayCurrencies(currencies);

        Console.Write("Geben Sie die Ausgangswährung ein: ");
        string sourceCurrency = Console.ReadLine().ToUpper();

        Console.Write("Geben Sie die Zielwährung ein: ");
        string targetCurrency = Console.ReadLine().ToUpper();

        // Betrag zum Umrechnen
        Console.Write("Geben Sie den Betrag ein: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        // Optionen für den Benutzer
        Console.WriteLine("Optionen:");
        Console.WriteLine("1. Normale Umrechnung");
        Console.WriteLine("2. Wechselkursdiagramm anzeigen");
        Console.WriteLine("3. Historischen Wechselkurs anzeigen");

        Console.Write("Geben Sie die gewünschte Option ein (1, 2 oder 3): ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                await PerformConversion(sourceCurrency, targetCurrency, amount);
                break;
            case 2:
                await DisplayExchangeRateChart(targetCurrency);
                break;
            case 3:
                Console.Write("Geben Sie das Datum für den historischen Wechselkurs ein (YYYY-MM-DD): ");
                string exchangeDate = Console.ReadLine();
                await DisplayHistoricalExchangeRate(targetCurrency, exchangeDate);
                break;
            default:
                Console.WriteLine("Ungültige Option.");
                break;
        }
    }

    private async Task PerformConversion(string sourceCurrency, string targetCurrency, decimal amount)
    {
        try
        {
            decimal convertedAmount = await ConvertCurrency(sourceCurrency, targetCurrency, amount);
            Console.WriteLine($"{amount} {sourceCurrency} entsprechen {convertedAmount} {targetCurrency}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler bei der Umrechnung: {ex.Message}");
        }
    }

    private async Task DisplayExchangeRateChart(string targetCurrency)
    {
        // Hier könnte Code stehen, um ein Diagramm der Wechselkurse anzuzeigen.
        Console.WriteLine($"Wechselkursdiagramm für {targetCurrency} wird angezeigt.");
    }

    private async Task DisplayHistoricalExchangeRate(string targetCurrency, string exchangeDate)
    {
        try
        {
            decimal exchangeRate = await GetHistoricalExchangeRate(targetCurrency, exchangeDate);
            Console.WriteLine($"Der historische Wechselkurs für {targetCurrency} am {exchangeDate} beträgt {exchangeRate}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler bei der Anzeige des historischen Wechselkurses: {ex.Message}");
        }
    }

    private async Task<decimal> GetHistoricalExchangeRate(string targetCurrency, string exchangeDate)
    {
        using (HttpClient client = new HttpClient())
        {
            string response = await client.GetStringAsync($"{ApiUrl}?date={exchangeDate}");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response);

            XmlNamespaceManager nsMgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsMgr.AddNamespace("ns", "http://www.sitemaps.org/schemas/sitemap/0.9");

            XmlNode rateNode = xmlDoc.SelectSingleNode($"/ns:urlset/ns:entry/ns:rates/ns:iso[@code='{targetCurrency}']/ns:rate", nsMgr);

            if (rateNode != null)
            {
                return decimal.Parse(rateNode.InnerText);
            }
            else
            {
                throw new InvalidOperationException($"Der historische Wechselkurs für {targetCurrency} am {exchangeDate} konnte nicht gefunden werden.");
            }
        }
    }

    private async Task<decimal> ConvertCurrency(string sourceCurrency, string targetCurrency, decimal amount)
    {
        using (HttpClient client = new HttpClient())
        {
            string response = await client.GetStringAsync(ApiUrl);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response);

            XmlNamespaceManager nsMgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsMgr.AddNamespace("ns", "http://www.sitemaps.org/schemas/sitemap/0.9");

            XmlNode rateNode = xmlDoc.SelectSingleNode($"/ns:urlset/ns:entry/ns:rates/ns:iso[@code='{targetCurrency}']/ns:rate", nsMgr);

            if (rateNode != null)
            {
                decimal exchangeRate = decimal.Parse(rateNode.InnerText);
                return amount * exchangeRate;
            }
            else
            {
                throw new InvalidOperationException($"Der Wechselkurs für {targetCurrency} konnte nicht gefunden werden.");
            }
        }
    }

    private List<string> GetAvailableCurrencies()
    {
        // Hier können Sie die Liste der verfügbaren Währungscodes anpassen
        return new List<string> { "USD", "EUR", "GBP", "JPY", "AUD", "CAD", "CHF", "CNY", "SEK", "NOK", "NZD", "SGD", "KRW", "TRY", "MXN", "BRL", "INR", "ZAR", "RUB", "HKD" };
    }

    private void DisplayCurrencies(List<string> currencies)
    {
        foreach (var currency in currencies)
        {
            Console.Write($"{currency} ");
        }
        Console.WriteLine();
    }
}
