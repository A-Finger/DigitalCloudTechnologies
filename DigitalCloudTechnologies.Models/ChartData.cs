using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCloudTechnologies.Models
{
	public class ChartData
	{
		private double[] _data;
		public string Name { get; set; }
		public double[] Data
		{
			get
			{
				return _data.Select(d => Math.Round(d, 2)).ToArray();
			}
			set
			{
				_data = value;
			}
		}
		public string[] XAxisLabels { get; set; }
	}
}
