﻿using Caliburn.Micro;
using ShipeeziAutomation.Extensions;
using ShipeeziAutomation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShipeeziAutomation
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container;
        public Bootstrapper()
        {
            Initialize();
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }
        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }
        protected override void Configure()
        {
            _container = new SimpleContainer();
            _container.Instance(_container);

            _container.ConfigureLogging();

            _container.ConfigureViewModels();

            GetType()
                .Assembly
                .GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType
                => _container
                .RegisterPerRequest(viewModelType, viewModelType.ToString(), viewModelType));
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            base.OnStartup(sender, e);
            DisplayRootViewForAsync<MainViewModel>();
        }
        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
