using DigitalPresc.Commands;
using DigitalPresc.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigitalPresc.ViewModels
{
    public class HistoryViewModel : ViewModelBase
    {
        public ICommand NavigationCommand { get; }

        public HistoryViewModel(NavigationStore navigationStore)
        {
            NavigationCommand = new HomeNavCommand(navigationStore);
        }
    }
}
