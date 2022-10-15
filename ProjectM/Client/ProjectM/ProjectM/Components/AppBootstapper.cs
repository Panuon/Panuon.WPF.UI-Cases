using Caliburn.Micro;
using ProjectM.Shared;
using ProjectM.UI;
using ProjectM.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ProjectM.Components
{
    public class AppBootstrapper
        : BootstrapperBase
    {
        #region Fields
        private CompositionContainer _container;

        private IWindowManager _windowManager;

        private IEventAggregator _eventAggregator;

        private ILogger _logger;

        private IThemeManager _themeManager;
        #endregion

        #region Ctor
        public AppBootstrapper()
        {
            Initialize();
        }
        #endregion

        #region Overrides
        protected override void Configure()
        {
            var aggregateCatalog = new AggregateCatalog(
                              AssemblySource.Instance.Select(x => new AssemblyCatalog(x)).OfType<ComposablePartCatalog>());

            var batch = new CompositionBatch();

            _container = new CompositionContainer(aggregateCatalog);

            batch.AddExportedValue(_container);

            //注入IoC
            _windowManager = new WindowManager();
            batch.AddExportedValue(_windowManager);
            _eventAggregator = new EventAggregator();
            batch.AddExportedValue(_eventAggregator);
            _logger = new Logger();
            batch.AddExportedValue(_logger);
            _themeManager = new ThemeManager();
            batch.AddExportedValue(_themeManager);

            _container.Compose(batch);
        }

        protected override void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            base.OnUnhandledException(sender, e);
        }

        protected override object GetInstance(Type service, string key)
        {
            string contract = string.IsNullOrEmpty(key)
               ? AttributedModelServices.GetContractName(service)
               : key;

            var exports = _container.GetExportedValues<object>(contract);

            if (exports.Any())
                return exports.First();

            throw new Exception($"找不到实例 {contract}。");
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetExportedValues<object>(AttributedModelServices.GetContractName(service));
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            var assemblies = new List<Assembly>()
            {
                Assembly.GetEntryAssembly(),
                Assembly.GetExecutingAssembly(),
            };

            return assemblies.Where(x => x != null)
                .Distinct();
        }

        protected override void BuildUp(object instance)
        {
            _container.SatisfyImportsOnce((ComposablePart)instance);
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            var viewModel = new ShellViewModel();
            _windowManager.ShowWindow(viewModel);
        }
        #endregion
    }
}
