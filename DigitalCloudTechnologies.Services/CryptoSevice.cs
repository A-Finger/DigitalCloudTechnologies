using DigitalCloudTechnologies.Models;
using DigitalCloudTechnologies.Models.Interfaces;
using DigitalCloudTechnologies.Services.Interfaces;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;

namespace DigitalCloudTechnologies.Services
{
	public class CryptoSevice : ICryptoSevice
	{
		private readonly HttpClient httpClient;
		public CryptoSevice()
		{
			httpClient = new HttpClient();
		}

		public async Task<IEnumerable<Crypto>> GetAllCryptosAsync()
		{

			Assets assets = await httpClient.GetFromJsonAsync<Assets>(@"https://api.coincap.io/v2/assets");
			return assets.Data;

		}

		public async Task<IEnumerable<Rate>> GetAllRatesAsync()
		{
			CryptoRates data = await httpClient.GetFromJsonAsync<CryptoRates>(@"https://api.coincap.io/v2/rates");
			return data.Data;
		}

		public async Task<ChartData> GetChartsAsync(string id, string interval)
		{
			string url = $@"https://api.coincap.io/v2/assets/{id.ToLower()}/history?interval={interval.ToLower()}";
			TradingHistory data = await httpClient.GetFromJsonAsync<TradingHistory>(url);
			ChartData chartSeries = new ChartData();
			chartSeries.XAxisLabels = data.Data.Select(x => x.Date.ToShortTimeString()).ToArray();
			var priceUSD = data.Data.Select(x=> x.PriceUsd).ToArray();
			chartSeries.Data = Array.ConvertAll(priceUSD, x => (double)x);
			chartSeries.Name = id.ToUpper();

			return chartSeries;
		}

		public Task<Crypto> GetCryptoAsync(string id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<ICrypto>> GetCryptoList()
		{
			return await GetAllCryptosAsync();
		}

		public async Task<IEnumerable<IntradayTrade>> GetIntradayTradesAsync(string id, string interval)
		{
			string url = $@"https://api.coincap.io/v2/assets/{id.ToLower()}/history?interval={interval.ToLower()}";

			TradingHistory data = await httpClient.GetFromJsonAsync<TradingHistory>(url);
			return data.Data;

		}



		public Task<Rate> GetRateAsync(string id)
		{
			throw new NotImplementedException();
		}
	}
}
