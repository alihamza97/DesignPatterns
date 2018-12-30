using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
	class SalesDiscount : Visitor
	{
		public SalesDiscount()
		{

		}
		public double visit(Fruits fruit)
		{
			return 0.90 * fruit.getPrice();
		}

		public double visit(Vegetables veg)
		{
			return 0.90 * veg.getPrice();
		}

		public double visit(DairyItems dairy)
		{
			return 0.90 * dairy.getPrice();
		}
	}
}
