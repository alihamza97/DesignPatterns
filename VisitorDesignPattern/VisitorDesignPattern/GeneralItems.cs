using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
	class GeneralItems : Element
	{
		public string name;
		public double price;

		public GeneralItems(string name,double price)
		{
			this.name = name;
			this.price = price;
		}
		public virtual double accept(Visitor visior)
		{
			return 0.0;
		}

		public double getPrice()
		{
			return price;
		}
		public string getName()
		{
			return name;
		}
	}
}
