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
    public class LoginViewModel : ViewModelBase
    {
        public ICommand NavigationCommand { get; }
        public LoginViewModel(NavigationStore navigationStore)
        {
            NavigationCommand = new HomeNavCommand(navigationStore);
        }
    }
}
