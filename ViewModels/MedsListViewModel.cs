﻿using DigitalPresc.Commands;
using DigitalPresc.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigitalPresc.ViewModels
{
    public class MedsListViewModel : ViewModelBase
    {
        public ICommand MedsListNavCommand { get; }
        public ICommand HomeNavCommand { get; }

        public MedsListViewModel(NavigationStore navigationStore)
        {
            MedsListNavCommand = new MedsListNavCommand(navigationStore);
            HomeNavCommand = new HomeNavCommand(navigationStore);
        }
    }
}
