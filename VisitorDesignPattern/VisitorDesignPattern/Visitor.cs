using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
	interface Visitor
	{
		double visit(Fruits fruit);
		double visit(Vegetables veg);
		double visit(DairyItems dairy);
	}
}
