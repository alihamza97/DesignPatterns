using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class Accessories : ICar
	{
		public string Description { get; set; }
		public double Price { get; set; }
		ICar C;

		public Accessories(ICar car)
		{
			this.C = car;
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
