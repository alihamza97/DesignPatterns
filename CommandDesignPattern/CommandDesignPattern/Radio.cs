using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
	public class Radio : Devices
	{
		int volController=0;
		public string DecreaseVol()
		{
			if (volController == 0)
			{
				volController = 0;
			}
			else
			{
				volController--;
				
			}
			return "vol of radio is decreasing:"+volController.ToString();

		}

		public string IncreaseVol()
		{
			volController++;
			return "vol of radio is increasing:"+volController.ToString();

		}

		public string Off()
		{
			return "Radio is turning off";
		}

		public string On()
		{
			return "Radio is turning On";
		}
	}
}
