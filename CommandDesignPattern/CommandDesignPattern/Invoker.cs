using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
	public class Invoker
	{
		Command command;
		public Invoker(Command cmd)
		{
			this.command = cmd;
		}

		public string Press()
		{
			return command.Execute();
		}
		public string Undo()
		{
			return command.Undo();
		}
	}
}
