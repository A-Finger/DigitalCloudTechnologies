namespace DigitalCloudTechnologies.Models
{
	public class IntradayTrade
	{
		public decimal PriceUsd { get; set; }
		public double Time { get; set; }
		public double? CirculatingSupply { get; set; }
		public DateTime Date { get; set; }
	}
}
