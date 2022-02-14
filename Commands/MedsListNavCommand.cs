
using DigitalPresc.Stores;
using DigitalPresc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPresc.Commands
{
    internal class MedsListNavCommand : CommandBase
    {
        private readonly NavigationStore _navigationCommand;

        public MedsListNavCommand(NavigationStore navigationCommand)
        {
            _navigationCommand = navigationCommand;
        }

        public override void Execute(object? parameter)
        {
            _navigationCommand.CurrentViewModel = new MedsListViewModel(_navigationCommand);
        }
    }
}
