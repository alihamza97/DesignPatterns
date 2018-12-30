using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorDesignPattern
{
	public partial class Form1 : Form
	{
		private GeneralItems generalItems;
		private List<GeneralItems> itemsList = new List<GeneralItems>();
		private goldenCustomerDiscount goldenCustomerDiscount;
		private SalesDiscount SalesDiscount;
		public Form1()
		{
			InitializeComponent();
			goldenCustomerDiscount = new goldenCustomerDiscount();
			SalesDiscount = new SalesDiscount();
		}
		
		private double discount = 0;
		public void Update()
		{
			 double sum = 0;
			listBox1.Items.Clear();
		
			foreach(GeneralItems g in itemsList)
			{
				
				listBox1.Items.Add(g.getName());
				listBox1.Items.Add(g.getPrice().ToString());
				sum += g.getPrice();

			}
			listBox1.Items.Add("total price: " + sum);


		}

		private void btndiscount_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
			 foreach(GeneralItems g in itemsList)
				{
					discount += g.accept(SalesDiscount);
				}
			}
			else if (radioButton2.Checked)
			{
				foreach(GeneralItems g in itemsList)
				{
					discount += g.accept(goldenCustomerDiscount);
				}

			}
			MessageBox.Show(" Prince after discount " + discount);
			discount = 0.0;
			

		}

		private void btnmilk_Click(object sender, EventArgs e)
		{
			generalItems = new DairyItems("milk", 2.5);
			itemsList.Add(generalItems);
			Update();

		}

		private void btnyogurt_Click(object sender, EventArgs e)
		{
			generalItems = new DairyItems("yogurt", 4.5);
			itemsList.Add(generalItems);
			Update();
		}

		private void btnorng_Click(object sender, EventArgs e)
		{
			generalItems = new DairyItems("orange", 0.5);
			itemsList.Add(generalItems);
			Update();
		}

		private void btnbanana_Click(object sender, EventArgs e)
		{
			generalItems = new DairyItems("banana", 1.5);
			itemsList.Add(generalItems);
			Update();
		}

		private void btncucumber_Click(object sender, EventArgs e)
		{
			generalItems = new DairyItems("cucumber", 3.5);
			itemsList.Add(generalItems);
			Update();
		}

		private void btntomate_Click(object sender, EventArgs e)
		{
			generalItems = new DairyItems("tomato", 5.5);
			itemsList.Add(generalItems);
			Update();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
