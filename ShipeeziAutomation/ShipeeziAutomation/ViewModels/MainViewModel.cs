using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipeeziAutomation.ViewModels
{
    class MainViewModel:Conductor<Screen>
    {
        private readonly SimpleContainer container;

        public MainViewModel(SimpleContainer container)
        {
            this.container = container;
        }

        public void EpcUploaderMenu()
        {
            Screen epcUploaderViewModel = container.GetInstance<EpcUploaderViewModel>();
            ActivateItemAsync(epcUploaderViewModel, System.Threading.CancellationToken.None);
        }

    }
}
