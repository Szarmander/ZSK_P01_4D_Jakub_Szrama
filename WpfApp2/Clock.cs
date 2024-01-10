using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WpfApp2
{
    public class Clock : INotifyPropertyChanged
    {
        private DispatcherTimer _timer;

        public string CurrentTime => DateTime.Now.ToLongTimeString();

        public event PropertyChangedEventHandler? PropertyChanged;

        public Clock()
        {
            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };

            _timer.Tick += (sender, o) => PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(CurrentTime)));

            _timer.Start();
        }
    }
}
