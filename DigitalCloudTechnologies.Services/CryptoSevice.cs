using DigitalCloudTechnologies.Models;
using DigitalCloudTechnologies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace DigitalCloudTechnologies.Services
{
	public class CryptoSevice : ICryptoSevice
	{
		private readonly HttpClient httpClient;
		public CryptoSevice()
		{
			httpClient = new HttpClient();
		}
		/// <summary>
		/// Point-in-time interval. Minute and hour intervals represent the price at that 
		/// time, the day interval represents the average of 24-hour periods (timezone: UTC)
		/// </summary>
		public List<string> Interval { get; } = null!;

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

		public Task<Crypto> GetCryptoAsync(string id)
		{
			throw new NotImplementedException();
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
