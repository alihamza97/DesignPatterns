using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
	public class TurnOff : Command
	{
		Devices device;

		public TurnOff(Devices dv)
		{
			this.device = dv;
		}


		public string Execute()
		{
			return device.Off();
		}

		public string Undo()
		{
			return device.On();
		}
	}
}
