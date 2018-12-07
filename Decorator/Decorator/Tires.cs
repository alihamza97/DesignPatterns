using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class Tires : Accessories
	{
		public Tires(ICar car) : base(car)
		{
			Description = "Tires";
			Price = 100;
		}
	}
}
