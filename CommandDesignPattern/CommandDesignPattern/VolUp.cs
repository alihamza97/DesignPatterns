using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
	class VolUp : Command
	{
		Devices devices;
		public VolUp(Devices d)
		{
			this.devices = d;
		}
		public string Execute()
		{
			return devices.IncreaseVol();
		}

		public string Undo()
		{
			return devices.DecreaseVol();
		}
	}
}
