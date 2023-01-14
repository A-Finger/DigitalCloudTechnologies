namespace DigitalCloudTechnologies.Models
{
	public class TradingHistory
	{
		public IEnumerable<IntradayTrade> Data { get; set; }
		public double Timestamp { get; set; }
	}
}
