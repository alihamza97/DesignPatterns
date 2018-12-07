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
    public partial class Form1 : Form
    {
        ISubject subject;
        IObserver observer;
        public Form1()
        {
            InitializeComponent();
            subject = new Subject();
            observer = new Observer2();
            ((Observer2)observer).ObserverEvent += EventUpdate;
            ((Subject)subject).Attach(observer);
            ((Observer2)observer).Show();

        }

        public void EventUpdate(Observer2 obs)
        {
            ((Subject)subject).Detach(obs);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IObserver newObs = new Observer2();
            ((Observer2)newObs).ObserverEvent += EventUpdate;
            ((Subject)subject).Attach(newObs);
            ((Observer2)newObs).Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            subject.Notify();
        }
    }
}
