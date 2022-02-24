using EES.Database;
using EES.Modules.EmployeeInfo;
using EES.Service;
using EES.Services.Interfaces;
using EES.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace EES
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IEmployeeService, EmployeeService>();
            containerRegistry.RegisterSingleton<ITransactionContext, TransactionContext>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<EmployeeInfoModule>();
        }
    }
}
