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
    public class PatientRegisterViewModel : ViewModelBase
    {
        public ICommand HomeNavCommand { get; }
        public ICommand SelMedsNavCommand { get; }

        public PatientRegisterViewModel(NavigationStore navigationStore)
        {
            HomeNavCommand = new HomeNavCommand(navigationStore);
            SelMedsNavCommand = new SelMedsNavCommand(navigationStore);
        }
    }
}
