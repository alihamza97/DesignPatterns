using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Subject : ISubject

    {
        int temp;
        int wind;
        List<IObserver> Observers;
        Random Random;

        public Subject()
        {
           Observers = new List<IObserver>();
            Random = new Random();
        }
        public void Attach(IObserver obs)
        {
            Observers.Add(obs);
        }

        public void Detach(IObserver obs)
        {
            Observers.Remove(obs);
        }

        public void Notify()
        {
            temp = Random.Next(0, 30);
            wind = Random.Next(0, 10);
            foreach(var items in Observers)
            {
                items.update(temp, wind);
            }
            
        }
    }
}
