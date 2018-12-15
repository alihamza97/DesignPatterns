using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class MeatPizza : IPizza
	{
		public string getPrice()
		{
			return " price=10$";
		}

		public string Name()
		{
			return "Meat Pizza";
		}
	}
}
