using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class Delivery
	{
		IFoodFactory foodFactory;
		IPizza pizza;
		IBurger burger;
		public Delivery(IFoodFactory f)
		{
			foodFactory = f;
			
			pizza = f.CreatePizza();
			burger = f.CreateBurger();

		}

		public string createOrder()
		{
			return pizza.Name() + "........" + burger.Name();
		}

		public string GetPrice()
		{
			return"\n" +pizza.getPrice() + ".........." + burger.getPrice();
		}
	}
}
