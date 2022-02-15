using DigitalPresc.Stores;
using DigitalPresc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPresc.Commands
{
    public class HistoryNavCommand : CommandBase
    {
        private readonly NavigationStore _navigationCommand;

        public HistoryNavCommand(NavigationStore navigationCommand)
        {
            _navigationCommand = navigationCommand;
        }

        public override void Execute(object? parameter)
        {
            _navigationCommand.CurrentViewModel = new HistoryViewModel(_navigationCommand);
        }
    }
}
