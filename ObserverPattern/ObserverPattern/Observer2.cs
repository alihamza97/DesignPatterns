using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Observer2 : Form,IObserver
    {
        public delegate void FormClosingHandler(Observer2 obs);
        public FormClosingHandler ObserverEvent;

        public Observer2()
        {
            InitializeComponent();
        }

        private void Observer2_Load(object sender, EventArgs e)
        {
            
        }

        public void update(int temp, int winds)
        {
            label3.Text = "" + temp;
            label4.Text = "" + winds;
        }

        private void Observer2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ObserverEvent(this);
        }
    }
}
