using Caliburn.Micro;
using ShipeeziAutomation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipeeziAutomation.Extensions
{
   public static class ViewModelExtension
    {
        public static void ConfigureViewModels(this SimpleContainer container)
        {
            container.PerRequest<EpcUploaderViewModel>();
            container.Singleton<IWindowManager, WindowManager>();
          
            container.RegisterPerRequest(typeof(MainViewModel), null, typeof(MainViewModel));
        }
    }
}
