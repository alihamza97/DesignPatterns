using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class VegFactory : IFoodFactory
	{
		public IBurger CreateBurger()
		{
			return (new VegBurger());
		}

		public IPizza CreatePizza()
		{
			return (new VegPizza());
		}
	}
}
