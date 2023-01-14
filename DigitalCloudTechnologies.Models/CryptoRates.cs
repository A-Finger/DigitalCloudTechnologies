namespace DigitalCloudTechnologies.Models
{
	public class CryptoRates
	{
		public IEnumerable<Rate> Data { get; set; }
		public double Timestamp { get; set; }
	}
}
