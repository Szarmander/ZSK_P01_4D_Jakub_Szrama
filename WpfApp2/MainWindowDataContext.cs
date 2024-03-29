﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class MainWindowDataContext : INotifyPropertyChanged
    {
        public MainWindowDataContext()
        {
        }

        public string? UserName { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private bool _isNameNeeded = true;

        public bool IsNameNeeded
        {
            get { return _isNameNeeded; }
            set
            {
                if (value != _isNameNeeded)
                {
                    _isNameNeeded = value;
                    PropertyChanged?.Invoke(
                        this, new PropertyChangedEventArgs(nameof(IsNameNeeded)));
                }
            }
        }
    }
}
