using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
	public class Speaker : Devices
	{
		int volController = 0;
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
			return "vol of speaker is decreasing:"+volController.ToString();

		}

		public string IncreaseVol()
		{
			volController++;
			return "vol of speaker is increasing:"+volController.ToString();

		}
		public string Off()
		{
			return "Speaker is turning off";
		}

		public string On()
		{
			return "Speaker is turning On";
		}
	}
}
