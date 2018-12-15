using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
	public partial class Form1 : Form
	{
		IFoodFactory FoodFactory;
		MeatFactory MeatFactory;
		Delivery delivery;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			delivery = new Delivery(new VegFactory());


			richTextBox1.Text += delivery.createOrder();
			richTextBox1.Text += delivery.GetPrice();


		}

		private void button2_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			delivery = new Delivery(new MeatFactory());
			
			
	 	    richTextBox1.Text+=	delivery.createOrder();
			richTextBox1.Text += delivery.GetPrice();

		}
	}
}
