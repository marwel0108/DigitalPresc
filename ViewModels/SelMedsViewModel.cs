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
    public class SelMedsViewModel : ViewModelBase
    {
        public ICommand MedsListNavCommand { get; }
        public ICommand HomeNavCommand { get; }

        public ICommand PatientRegisterNavCommand { get; }

        public SelMedsViewModel(NavigationStore navigationStore)
        {
            MedsListNavCommand = new MedsListNavCommand(navigationStore);
            HomeNavCommand = new HomeNavCommand(navigationStore);
            PatientRegisterNavCommand = new PatientRegisterNavCommand(navigationStore);
        }
    }
}
