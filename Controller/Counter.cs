using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace familienfest.Controller
{
    public class Counter : INotifyPropertyChanged
    {
        public static readonly Counter _instance = new Counter();
        public event PropertyChangedEventHandler PropertyChanged;

        Counter()
        {
            Count = 0;
        }

        private int _count = 0;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
            }
        }

        public void CountUp()
        {
            Count++;
        }
        public void CountDown()
        {
            Count--;
        }

        public async void CountToZero()
        {
            while (Counter._instance.Count > 0)
            {
                Counter._instance.CountDown();
                await Task.Delay(1000);
            }
        }
    }
}
