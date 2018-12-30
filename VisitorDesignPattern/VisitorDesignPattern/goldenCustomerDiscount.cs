using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
	class goldenCustomerDiscount : Visitor
	{
		public goldenCustomerDiscount()
		{

		}
		public double visit(Fruits fruit)
		{
			return 0.70 * fruit.getPrice();
		}

		public double visit(Vegetables veg)
		{
			return 0.70 * veg.getPrice();
		}

		public double visit(DairyItems dairy)
		{
			return 0.70 * dairy.getPrice();
		}
	}
}
