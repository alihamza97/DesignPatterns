using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class VegBurger : IBurger
	{
		public string getPrice()
		{
			string price = " price=2$";
			return price;
		}

		public string Name()
		{
			return "veg burger";

		}
	}
}
