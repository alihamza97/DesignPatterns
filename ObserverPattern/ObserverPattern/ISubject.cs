﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface ISubject
    {
        void Attach(IObserver obs);
        void Detach(IObserver obs);
        void Notify();




    }
}
