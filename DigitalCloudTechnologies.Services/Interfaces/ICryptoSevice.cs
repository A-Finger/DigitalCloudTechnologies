using DigitalCloudTechnologies.Models;

namespace DigitalCloudTechnologies.Services.Interfaces
{
	public interface ICryptoSevice
	{
		public Task<IEnumerable<Crypto>> GetAllCryptosAsync();
		public Task<Crypto> GetCryptoAsync(string id);
		public Task<IEnumerable<Rate>> GetAllRatesAsync();
		public Task<Rate> GetRateAsync(string id);
		public Task<IEnumerable<IntradayTrade>> GetIntradayTradesAsync(string id, string interval);
		public Task<ChartData> GetChartsAsync(string id, string interval);
	}
}
