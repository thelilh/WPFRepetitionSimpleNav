using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRepetition.Models
{
    public class DataModel
    {
        private int _counter;
        public int Counter
        {
            get
            {
                return _counter;
            }
            set
            {
                //Hej
                //Hej
                _counter = value;
                CounterChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler<EventArgs> CounterChanged;
    }
}
