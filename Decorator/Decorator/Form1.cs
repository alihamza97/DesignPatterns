using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
	public partial class Form1 : Form
	{
		ICar C;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				C = new Car("Range Rover", 40000);
			}
			if (radioButton2.Checked)
			{
				C = new Car("Audi", 30000);
			}
			if (radioButton3.Checked)
			{
				C = new Bullbar(C);
			}
			if (radioButton4.Checked)
			{
				C = new Tires(C);
			}
			if (radioButton5.Checked)
			{
				C = new Airco(C);
			}

			double price=C.GetPrice();
			textBox1.Text = Convert.ToString(price);
			listBox1.Items.Add(C.GetDescription());
			

		}
	}
}
