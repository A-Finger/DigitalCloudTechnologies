using DigitalCloudTechnologies.Models.Interfaces;

namespace DigitalCloudTechnologies.Models
{
	public class Crypto : ICrypto
	{
		/// <summary>
		/// Unique identifier for asset
		/// </summary>
		public string? Id { get; set; }
		/// <summary>
		/// Most common symbol used to identify this asset on an exchange
		/// </summary>
		public string? Symbol { get; set; }
		/// <summary>
		/// Proper name for asset
		/// </summary>
		public string? Name { get; set; }
		/// <summary>
		/// Rank is in ascending order - this number is directly associated with
		/// the marketcap whereas the highest marketcap receives rank 1
		/// </summary>
		public int? Rank { get; set; }
		/// <summary>
		/// Available supply for trading
		/// </summary>
		public double? Supply { get; set; }
		/// <summary>
		/// Total quantity of asset issued
		/// </summary>
		public double? MaxSupply { get; set; }
		/// <summary>
		/// Supply x price
		/// </summary>
		public double? MarketCapUsd { get; set; }
		/// <summary>
		/// Quantity of trading volume represented in USD over the last 24 hours
		/// </summary>
		public double? VolumeUsd24Hr { get; set; }
		/// <summary>
		/// Volume-weighted price based on real-time market data, translated to USD
		/// </summary>
		public double? PriceUsd { get; set; }
		/// <summary>
		/// The direction and value change in the last 24 hours
		/// </summary>
		public double? ChangePercent24Hr { get; set; }
		/// <summary>
		/// Volume weighted average price (VWAP) in the last 24 hours
		/// </summary>
		public double? Vwap24Hr { get; set; }
	}
}
