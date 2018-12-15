using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class VegPizza : IPizza
	{
		public string getPrice()
		{
			return "price=8$";
		}

		public string Name()
		{
			return "Veg Pizza";
		}
	}
}
