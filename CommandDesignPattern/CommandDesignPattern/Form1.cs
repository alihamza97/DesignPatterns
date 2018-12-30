using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandDesignPattern
{
	public partial class Form1 : Form
	{
		private Devices myDevice=new Radio();
		private Invoker invoke;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			lbStatus.Items.Clear();
			TurnOff turnOffDevice = new TurnOff(myDevice);
			invoke = new Invoker(turnOffDevice);
			lbStatus.Items.Add(invoke.Press());

		}

		private void button2_Click(object sender, EventArgs e)
		{
			lbStatus.Items.Clear();
			TurnOn turnOn = new TurnOn(myDevice);
			invoke = new Invoker(turnOn);
			lbStatus.Items.Add(invoke.Press());

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			myDevice = new Radio();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			myDevice = new Speaker();
		}

		private void button3_Click(object sender, EventArgs e)
		{

			lbStatus.Items.Clear();
			lbStatus.Items.Add(invoke.Undo());

			

		}

		private void button4_Click(object sender, EventArgs e)
		{
			lbStatus.Items.Clear();
			VolDown voldown = new VolDown(myDevice);
			invoke = new Invoker(voldown);
			lbStatus.Items.Add(invoke.Press());
		}

		private void button5_Click(object sender, EventArgs e)
		{


			lbStatus.Items.Clear();
			VolUp volUp = new VolUp(myDevice);
			invoke = new Invoker(volUp);

			lbStatus.Items.Add(invoke.Press());
		}
	}
}
