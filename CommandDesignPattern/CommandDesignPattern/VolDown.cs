using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
	class VolDown : Command
	{
		Devices devices;
		public VolDown(Devices d)
		{
			this.devices = d;
		}
		public string Execute()
		{
			return devices.DecreaseVol();
		}

		public string Undo()
		{
			return devices.IncreaseVol();
		}
	}
}
