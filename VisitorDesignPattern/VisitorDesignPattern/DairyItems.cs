using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
	class DairyItems : GeneralItems,Element
	{
		public DairyItems(string name, double price) : base(name, price)
		{
		}
		public override double accept(Visitor visior)
		{
			return visior.visit(this);
		}
	}
}
