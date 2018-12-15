using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class MeatBurger : IBurger
	{
		public string getPrice()
		{
			string price = " price=4$";
			return price+="";
		}

		public string Name()
		{
			return "Meat Burger";
		}
	}
}
