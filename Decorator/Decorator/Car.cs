using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class Car : ICar
	{
		public string Description { get; set; }
		public double Price { get; set; }

		public Car(string desc,double price)
		{
			this.Description = desc;
			this.Price = price;
		}

		public string GetDescription()
		{
			return this.Description;
		}

		public double GetPrice()
		{
			return this.Price;
		}
	}
}
