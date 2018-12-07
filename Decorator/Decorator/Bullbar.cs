using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class Bullbar : Accessories
	{
		public Bullbar(ICar car) : base(car)
		{
			Description = "BullBar";
			Price = 200;
		}
	}
}
