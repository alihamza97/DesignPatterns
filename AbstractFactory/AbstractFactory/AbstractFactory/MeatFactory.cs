using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class MeatFactory : IFoodFactory
	{
		public IBurger CreateBurger()
		{
			return (new MeatBurger());
		}

		public IPizza CreatePizza()
		{
			return (new MeatPizza());
		}
	}
}
