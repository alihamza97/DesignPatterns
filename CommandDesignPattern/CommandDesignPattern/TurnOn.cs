using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
	public class TurnOn : Command
	{

		Devices device;
		public TurnOn(Devices dv)
		{
			this.device = dv;
		}
		public string Execute()
		{
			return device.On();
			
		}

		public string Undo()
		{
			return device.Off();
		}
	}
}
