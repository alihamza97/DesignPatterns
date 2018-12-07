using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class Airco : Accessories
	{
		public Airco(ICar car) : base(car)
		{
			Description = "Airco";
			Price = 300;
		}
	}
}
